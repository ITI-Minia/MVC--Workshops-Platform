using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using MimeKit;

namespace WorkshopPlatform.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private IWebHostEnvironment _env;

        public ForgotPasswordModel(UserManager<IdentityUser> userManager, IEmailSender emailSender
            , IWebHostEnvironment env)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _env = env;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email filed is required")]
            [EmailAddress]
            [BindProperty]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    // Don't reveal that the user does not exist or is not confirmed
                    return RedirectToPage("./ForgotPasswordConfirmation");
                }

                // For more information on how to enable account confirmation and password reset please
                // visit https://go.microsoft.com/fwlink/?LinkID=532713
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);

                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code, email = user.Email },
                    protocol: Request.Scheme);

                var pathToFile = _env.WebRootPath
                  + Path.DirectorySeparatorChar.ToString()
                  + "Templates"
                  + Path.DirectorySeparatorChar.ToString()
                  + "EmailTemplate"
                  + Path.DirectorySeparatorChar.ToString()
                  + "ResetPasswordEmail.html";

                var builder = new BodyBuilder();

                using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                {
                    builder.HtmlBody = SourceReader.ReadToEnd();
                }

                //use string.Format(format item, dynamic values as parameters) In our case, {x}
                //values in Templates are to replace by dynamic values.
                string messageBody = string.Format(builder.HtmlBody,
                    HtmlEncoder.Default.Encode(callbackUrl));

                await _emailSender.SendEmailAsync(
                    Input.Email, "Reset Password", messageBody);

                return RedirectToPage("./ForgotPasswordConfirmation");
            }

            return Page();
        }
    }
}