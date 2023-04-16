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

namespace GymMasterPro.Pages.Trainers
{
    public class CreateModel : PageModel
    {
        private readonly GymMasterPro.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(GymMasterPro.Data.ApplicationDbContext context , UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trainer Trainer { get; set; } = default!;
        

      

        // when user click save this will be updated
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Trainers == null || Trainer == null)
            {
                return Page();
            }
        
          var loggedInUser = await _userManager.GetUserAsync(User);
            if (loggedInUser == null)
            {
                return Page();
            }
           // making code behind Created
            Trainer.UpdateAt = DateTime.Now;
            Trainer.CreatedAt = DateTime.Now;
            Trainer.CreatedBy = loggedInUser?.UserName; 
            _context.Trainers.Add(Trainer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
