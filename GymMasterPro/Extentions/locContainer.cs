using Repository;
using Services;
using Services.Interfaces;

namespace GymMasterPro.Extentions
{
    public static class locContainer
    {

        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<ITrainerService, TrainerService>();
            services.AddScoped<ICheckinService, CheckinService>();
            services.AddScoped<IPlanService, PlanService>();
            services.AddScoped<IMembershipService, MembershipService>();
        }
    }
}
