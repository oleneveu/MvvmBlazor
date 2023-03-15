namespace MvvmBlazor.ServicesScope
{
    public interface IServiceProvidersSetter
    {
        void SetServiceProviders(IServiceProvider rootServiceProvider, IServiceProvider scopedServiceProvider);
    }
}
