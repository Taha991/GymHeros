
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Model;
using Services.Interfaces;

namespace GymMasterPro.Pages.Checkins
{
    public class IndexModel : PageModel
    {
        private readonly ICheckinService _checkinService;

        public IndexModel(ICheckinService checkinService)
        {
            _checkinService = checkinService;
        }

        public IList<Checkin> Checkin { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Checkin = await _checkinService.GetCheckins();
        }
    }
}
