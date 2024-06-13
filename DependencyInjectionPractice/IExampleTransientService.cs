using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPractice
{
    public interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
    }
}