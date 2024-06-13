namespace DependencyInjectionPractice;

    internal sealed class ServiceLifetimeReporter(
        IExampleTransientService transientService,
        IExampleScopedService scopedService,
        IExampleSingletonService singletonService)
        {
            public void ReportserviceLifetimeDetails(string lifetimeDetails)
            {
                Console.WriteLine(lifetimeDetails);

                LogService(transientService, "Always different");
                LogService(scopedService, "Changes only with lifetime");
                LogService(singletonService, "Always the same");
            }
        

        private static void LogService<T>(T service, string mesage)
            where T : IReportServiceLifetime =>
                Console.WriteLine(
                    $"      {typeof(T).Name}: {service.Id} ({mesage})");
        }
