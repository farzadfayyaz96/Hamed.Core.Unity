namespace Code.Shared.Collections.Abstractions
{
    public interface IServiceProvider
    {
        ServiceCollection Services { get; }
        
        void Build();
    }
}