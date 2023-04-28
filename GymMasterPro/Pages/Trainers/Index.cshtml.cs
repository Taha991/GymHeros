
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Services.Interfaces;

namespace GymMasterPro.Pages.Trainers
{
    public class IndexModel : PageModel
    {
        private readonly ITrainerService _trainerService;

        public IndexModel(ITrainerService trainerService)
        {
            _trainerService = trainerService;
        }

        public IList<Trainer> Trainer { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Trainer = await _trainerService.GetTrainers();
        }
    }
}
