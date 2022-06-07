using Microsoft.Extensions.DependencyInjection;

namespace MvvmBlazor.ServicesScope;

internal class MvvmServiceScopeFactory : IMvvmServiceScopeFactory
{
    private readonly IServiceScopeFactory serviceScopeFactory;

    public MvvmServiceScopeFactory(IServiceScopeFactory serviceScopeFactory)
    {
        this.serviceScopeFactory = serviceScopeFactory;
    }

    public IServiceScope CreateScope() => serviceScopeFactory.CreateScope();
}
