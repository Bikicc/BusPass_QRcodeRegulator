using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NCrontab;

namespace BusPass.Server.Services {
    public class CronService : BackgroundService, IHostedService {
        private CrontabSchedule _schedule;
        private DateTime _nextRun;
        private string Schedule => "0/60 * * * * *"; //Runs every minute
        //private string Schedule => "0 0 0 * * *"; Runs every day at midnight

        public IServiceScopeFactory _serviceScopeFactory;

        public CronService (IServiceScopeFactory serviceScopeFactory) {
            _schedule = CrontabSchedule.Parse (Schedule, new CrontabSchedule.ParseOptions { IncludingSeconds = true });
            _nextRun = _schedule.GetNextOccurrence (DateTime.Now);
            _serviceScopeFactory = serviceScopeFactory;
        }

        protected override async Task ExecuteAsync (CancellationToken stoppingToken) {
            using (var scope = _serviceScopeFactory.CreateScope ()) {
                var bpService = scope.ServiceProvider.GetRequiredService<IBusPassportService>();
                do {
                    var now = DateTime.Now;
                    var nextrun = _schedule.GetNextOccurrence (now);
                    if (now > _nextRun) {
                        Process (bpService);
                        _nextRun = _schedule.GetNextOccurrence (DateTime.Now);
                    }
                    await Task.Delay (5000, stoppingToken); //5 seconds delay
                }
                while (!stoppingToken.IsCancellationRequested);
            }
        }
        private void Process (IBusPassportService bpService) {
            bpService.changePasswordValidityIfExpired ();
        }
    }
}