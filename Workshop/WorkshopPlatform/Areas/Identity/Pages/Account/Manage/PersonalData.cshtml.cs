using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Areas.Identity.Pages.Account.Manage
{
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<PersonalDataModel> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly WorkShopDbContext _context;

        public PersonalDataModel(
            UserManager<IdentityUser> userManager,
            ILogger<PersonalDataModel> logger,
            WorkShopDbContext context,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _logger = logger;
            _signInManager = signInManager;
            _context = context;
        }
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {

            public string CarModel { get; set; }
            public string CarBrand { get; set; }
            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            public string City { get; set; }
            [Required]
            [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
            public string Government { get; set; }

        }

        private async Task LoadAsync(IdentityUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var userid = await _userManager.GetUserIdAsync(user);
            var userProfile = _context.UserProfiles.Where(u => u.UserId == userid).FirstOrDefault();
            var government = userProfile.Government;
            var city = userProfile.City;

            var brand = userProfile.CarBrand;
            var model = userProfile.CarModel;


            Input = new InputModel
            {
                Government = government,
                City = city,
                CarBrand = brand,
                CarModel = model,
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
            var government = userprofile.Government;
            var city = userprofile.City;
            var fName = userprofile.FirstName;
            var lName = userprofile.LastName;
            var brand = userprofile.CarBrand;
            var model = userprofile.CarModel;
            var img = userprofile.Image;


            if (Input.Government != government)
            {
                userprofile.Government = Input.Government;
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
            _context.SaveChanges();
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your data has been updated";
            return RedirectToPage();
        } 

    }
}