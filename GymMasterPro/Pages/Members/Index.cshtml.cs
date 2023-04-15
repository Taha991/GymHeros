using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GymMasterPro.Data;
using GymMasterPro.Model;

namespace GymMasterPro.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly GymMasterPro.Data.ApplicationDbContext _context;

        public IndexModel(GymMasterPro.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Members != null)
            {
                Member = await _context.Members
                .Include(m => m.Trainer).ToListAsync();
            }
        }
    }
}
