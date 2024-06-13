using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionPractice;

    public interface IReportServiceLifetime
    {
        Guid Id { get; }

        ServiceLifetime Lifetime { get; }
    }
