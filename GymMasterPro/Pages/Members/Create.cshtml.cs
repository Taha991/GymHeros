using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GymMasterPro.Data;
using GymMasterPro.Model;
using Microsoft.AspNetCore.Identity;

namespace GymMasterPro.Pages.Members
{
    public class CreateModel : PageModel
    {
        private readonly GymMasterPro.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(GymMasterPro.Data.ApplicationDbContext context ,UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
        ViewData["TrainerId"] = new SelectList(_context.Trainers, "Id", "FirstName");
            return Page();
        }

        [BindProperty]
        public Member Member { get; set; } = default!;


      
        // when user click save this will be updated
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Members == null || Member == null)
            {
                return Page();
            }
          var logInUser = await _userManager.GetUserAsync(User);
            if (logInUser == null)
            {
                return Page();
            }
            // making code behind Created
            Member.CreatedAt = DateTime.Now;
            Member.UpdateAt = DateTime.Now;
            Member.CreatedBy = logInUser?.UserName;
            _context.Members.Add(Member);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
