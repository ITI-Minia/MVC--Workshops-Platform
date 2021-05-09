using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly WorkShopDbContext _context;

        [Obsolete]
        private readonly IHostingEnvironment hosting;

        [Obsolete]
        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            WorkShopDbContext context,
            IHostingEnvironment hosting)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            this.hosting = hosting;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public string Image { get; set; }

        public IFormFile ImageFile { get; set; }

        [BindProperty]
        public string RemoveImage { get; set; } = "false";

        public class InputModel
        {
            [Phone]
            [Required]
            [RegularExpression(@"^(012||011||015||010)\d{8}$", ErrorMessage = "Invalid phone number")]
            [Display(Name = "Phone")]
            public string PhoneNumber { get; set; }

            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            [Display(Name = "Last name")]
            public string LastName { get; set; }
        }

        private async Task LoadAsync(IdentityUser user)
        {
            var userid = await _userManager.GetUserIdAsync(user);
            Username = await _userManager.GetUserNameAsync(user);

            var userProfile = _context.UserProfiles.Where(u => u.UserId == userid).FirstOrDefault();
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var fName = userProfile.FirstName;
            var lName = userProfile.LastName;

            Input = new InputModel { PhoneNumber = phoneNumber, FirstName = fName, LastName = lName };

            Image = userProfile.Image;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userid = _userManager.GetUserId(User);
            var userprofile = _context.UserProfiles.Where(u => u.UserId == userid).FirstOrDefault();

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userid}'.");
            }
            await LoadAsync(user);
            return Page();
        }

        [Obsolete]
        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userid = _userManager.GetUserId(User);
            var userprofile = _context.UserProfiles.Where(u => u.UserId == userid).FirstOrDefault();

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var fName = userprofile.FirstName;
            var lName = userprofile.LastName;

            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.FirstName != fName)
            {
                userprofile.FirstName = Input.FirstName;
            }

            if (Input.LastName != lName)
            {
                userprofile.LastName = Input.LastName;
            }

            string fileName = string.Empty;

            if (ImageFile != null)
            {
                fileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;

                //image path
                string uploads = Path.Combine(hosting.WebRootPath, "Upload/images");
                string Fullpath = Path.Combine(uploads, fileName);

                //copy (upload) image to that path
                ImageFile.CopyTo(new FileStream(Fullpath, FileMode.Create));

                if (userprofile.Image != null)
                {
                    string OldImgPath = Path.Combine(uploads, userprofile.Image);
                    try
                    {
                        System.IO.File.Delete(OldImgPath);
                    }
                    catch
                    {
                        StatusMessage = "Unexpected error when trying to set Photo.";
                    }
                }
                userprofile.Image = fileName;
            }
            else
            {
                if (RemoveImage == "true")
                {
                    userprofile.Image = null;
                }
            }

            _context.SaveChanges();
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";

            return RedirectToPage();
        }
    }
}