using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using WorkshopPlatform.Models;

namespace WorkshopPlatform.Areas.Identity.Pages.Account
{
    public class WorkshopSetLocationModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly WorkShopDbContext _context;

        public WorkshopSetLocationModel(SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            WorkShopDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        public string UserId { get; set; }

        [Required]
        [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
        [PageRemote(ErrorMessage = "Invalid government name (check your input or we doesn't support it yet).",
            HttpMethod = "post",
            PageHandler = "CheckGovernment",
            AdditionalFields = "__RequestVerificationToken")]
        [BindProperty]
        public string Government { get; set; }

        [Required]
        [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
        [PageRemote(ErrorMessage = "The government doesn't contain this city",
            HttpMethod = "post",
            PageHandler = "CheckCity",
            AdditionalFields = "__RequestVerificationToken")]
        [BindProperty]
        public string City { get; set; }

        [Required]
        [RegularExpression("[A-Za-z -]{3,}", ErrorMessage = "Enter 3 or more letters (special characters not allowed)")]
        [BindProperty]
        public string Street { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            UserId = userId;

            //confirm user (workshop) email
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var workshop = _context.WorkShops.Where(w => w.UserId == UserId).FirstOrDefault();

            if (ModelState.IsValid)
            {
                //set work shop Location
                var government = _context.Governments.Where(g => g.Name == Government).FirstOrDefault();
                var city = _context.Cities.Where(c => c.Name == City && c.GovernmentId == government.Id).FirstOrDefault();

                workshop.CityId = city.Id;
                workshop.Address = Street;

                await _context.SaveChangesAsync();
            }

            return new RedirectToPageResult("/WorkshopComplete");
        }

        public JsonResult OnPostCheckCity()
        {
            City city = null;

            var government = _context.Governments.Where(g => g.Name == Government).FirstOrDefault();

            if (government != null)
                city = _context.Cities.Where(c => c.Name == City && c.GovernmentId == government.Id).FirstOrDefault();

            var valid = city != null;

            return new JsonResult(valid);
        }

        public JsonResult OnPostCheckGovernment()
        {
            var government = _context.Governments.Where(g => g.Name == Government).FirstOrDefault();

            var valid = government != null;

            return new JsonResult(valid);
        }
    }
}