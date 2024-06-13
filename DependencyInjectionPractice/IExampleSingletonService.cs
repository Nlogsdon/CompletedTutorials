using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPractice;

    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
    }
