using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MimeKit;
using Workshop.Models;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly WorkShopDbContext _context;
        private readonly IWebHostEnvironment _env;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            WorkShopDbContext context,
            IWebHostEnvironment env)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
            _env = env;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        [Required(ErrorMessage = "Username field is required")]
        [RegularExpression("^([a-z0-9]|[-._@](?![-._])){3,}$", ErrorMessage = "Enter 3 or more letter (no special chars or space and start with letter)")]
        [PageRemote(ErrorMessage = "Username already exists",
            HttpMethod = "post",
            PageHandler = "CheckUsername",
            AdditionalFields = "__RequestVerificationToken")]
        [BindProperty]
        public string UsernameInput { get; set; }

        [Required(ErrorMessage = "Email filed is required")]
        [EmailAddress]
        [Display(Name = "Email")]
        [PageRemote(ErrorMessage = "Email address already exists",
            HttpMethod = "post",
            PageHandler = "CheckEmail",
            AdditionalFields = "__RequestVerificationToken")]
        [BindProperty]
        public string EmailInput { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            public string Username { get; set; }

            //[Required]
            //[RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            //[Display(Name = "First name")]
            //public string FirstName { get; set; }

            //[Required]
            //[RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            //[Display(Name = "Last name")]
            //public string LastName { get; set; }

            public string Email { get; set; }

            [Required]
            [RegularExpression(@"^(012||011||015||010)\d{8}$", ErrorMessage = "Invalid phone number")]
            [Display(Name = "Phone number")]
            public string Phone { get; set; }

            [Required]
            [DataType(DataType.Password)]
            //[RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z-\W]{8,}$", ErrorMessage = "Password must be at least 8 characters long with one (digit, upper and lower case letter).")]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                Input.Username = UsernameInput;
                Input.Email = EmailInput;

                IdentityUser user = new()
                {
                    UserName = Input.Username,
                    Email = Input.Email,
                    PhoneNumber = Input.Phone,
                };

                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    #region assign to role

                    if (await _roleManager.FindByNameAsync("User") == null)
                    {
                        result = await _roleManager.CreateAsync(new IdentityRole("User"));
                    }
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "User");
                    }

                    #endregion assign to role

                    #region create user profile

                    _context.UserProfiles.Add(new UserProfile
                    {
                        //FirstName = Input.FirstName,
                        //LastName = Input.LastName,
                        UserId = user.Id
                    });

                    _context.SaveChanges();

                    #endregion create user profile

                    _logger.LogInformation("User created a new account with password.");

                    #region Email confirmation

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    var pathToFile = _env.WebRootPath
                       + Path.DirectorySeparatorChar.ToString()
                       + "Templates"
                       + Path.DirectorySeparatorChar.ToString()
                       + "EmailTemplate"
                       + Path.DirectorySeparatorChar.ToString()
                       + "RegisterConfirmationEmail.html";

                    var builder = new BodyBuilder();

                    using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                    {
                        builder.HtmlBody = SourceReader.ReadToEnd();
                    }

                    //use string.Format(format item, dynamic values as parameters) In our case, {x}
                    //values in Templates are to replace by dynamic values.
                    string messageBody = string.Format(builder.HtmlBody, "",
                        HtmlEncoder.Default.Encode(callbackUrl));

                    await _emailSender.SendEmailAsync(user.Email, "Confirm your email", messageBody);

                    #endregion Email confirmation

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        public JsonResult OnPostCheckEmail()
        {
            var user = _userManager.FindByEmailAsync(EmailInput).Result;
            var valid = user == null;
            return new JsonResult(valid);
        }

        public JsonResult OnPostCheckUsername()
        {
            var user = _userManager.FindByNameAsync(UsernameInput).Result;
            var valid = user == null;
            return new JsonResult(valid);
        }
    }
}