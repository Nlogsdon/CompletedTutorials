using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPractice;

    public interface IExampleScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
