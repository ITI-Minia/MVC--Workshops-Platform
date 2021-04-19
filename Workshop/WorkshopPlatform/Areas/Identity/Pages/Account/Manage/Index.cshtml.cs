using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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


        public IndexModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            WorkShopDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public string Username { get; set; }
      

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Required]
            [RegularExpression(@"^(012||011||015||010)\d{8}$", ErrorMessage = "Invalid phone number")]
            [Display(Name = "Phone number")] public string PhoneNumber { get; set; }



            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            [Display(Name = "Last name")]
            public string LastName { get; set; }


            public string CarModel { get; set; }
            public string CarBrand { get; set; }
            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            public string City { get; set; }
            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            public string Government { get; set; }
            public string Image { get; set; }

        }

        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var userid = await _userManager.GetUserIdAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var userProfile=_context.UserProfiles.Where(u => u.UserId == userid).FirstOrDefault();
            var government = userProfile.Government;
            var city = userProfile.City;
            var fName = userProfile.FirstName;
            var lName = userProfile.LastName;
            var brand = userProfile.CarBrand;
            var model = userProfile.CarModel;
            var img = userProfile.Image;
            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Government = government,
                City = city,
                FirstName = fName,
                LastName = lName,
                CarBrand = brand,
                CarModel = model,
                 Image = img,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }          
            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userid =  _userManager.GetUserId(User);
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
            var government = userprofile.Government;
            var city = userprofile.City;
            var fName = userprofile.FirstName;
            var lName = userprofile.LastName;
            var brand = userprofile.CarBrand;
            var model = userprofile.CarModel;
            var img = userprofile.Image;
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.Government != government)
            {
                userprofile.Government = Input.Government;               
            }
            if (Input.FirstName != fName)
            {
                userprofile.FirstName = Input.FirstName;
            }

            if (Input.LastName != lName)
            {
                userprofile.LastName = Input.LastName;
            }
            if (Input.City != city)
            {
                userprofile.City = Input.City;
            }

            if (Input.CarBrand != brand)
            {
                userprofile.CarBrand = Input.CarBrand;
            }
            if (Input.CarModel != model)
            {
                userprofile.CarModel = Input.CarModel;
            }
            if (Input.Image != img)
            {
                userprofile.Image = Input.Image;
            }
            _context.SaveChanges();
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
