using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using MimeKit;
using WorkshopPlatform.Models;
using System.Linq;

namespace WorkshopPlatform.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _sender;
        private IWebHostEnvironment _env;
        private readonly WorkShopDbContext _context;

        public RegisterConfirmationModel(UserManager<IdentityUser> userManager, IEmailSender sender
            , IWebHostEnvironment env, WorkShopDbContext context)
        {
            _userManager = userManager;
            _sender = sender;
            _env = env;
            _context = context;
        }

        public string Email { get; set; }

        public bool DisplayConfirmAccountLink { get; set; }

        public string EmailConfirmationUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string email, string returnUrl = null, bool resend = false)
        {
            if (email == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            Email = email;

            if (resend)
            {
                var profile = _context.UserProfiles.Where(u => u.UserId == user.Id).FirstOrDefault();

                TempData.Add("resend", true);

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
                string messageBody = string.Format(builder.HtmlBody, profile.FirstName,
                    HtmlEncoder.Default.Encode(callbackUrl));

                await _sender.SendEmailAsync(user.Email, "Confirm your email", messageBody);

                return RedirectToPage("RegisterConfirmation", new { email = user.Email, returnUrl = returnUrl });
            }

            return Page();
        }
    }
}