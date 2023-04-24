using GymMasterPro.Data;
using GymMasterPro.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GymMasterPro.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger , GymMasterPro.Data.ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public int TotalMember { get; set; } = default!;
        public int TotalTrainers { get; set; } = default!;
        public int ActiveMembers { get; set; } = default!;
        public int InActiveMembers { get; set; } = default!;
        public int? ExpiredMemberShip { get; set; } = default!;
        public IList<Member>? Members { get; set; } = default!;


        public  async Task OnGet()
        {
            if(_context.Trainers != null)
            {
                TotalMember = await _context.Members.CountAsync();
            }
            //TotalMember = await _memberService.GetMembersCount();
            //TotalTrainers = await _trainerService.GetTrainersCount();
            //ActiveMembers = await _memberService.GetActiveMembers();
            //ExpiredMemberShip = (await _memberService.GetExpiredMembers())?.Count();
            //InActiveMembers = await _memberService.GetInactiveMembers();
            //Members = (await _memberService.GetExpiredMembers())?.ToList();
        }
    }
}