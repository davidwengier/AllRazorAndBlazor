namespace AllRazorAndBlazor.Pages
{
    public interface IService
    {
        string DoSomething<T>();
        Task<string> DoSomethingAsync();

        IDisposable? GetDisposable();
    }

    public class Service : IService
    {
        public string DoSomething<T>() => typeof(T).ToString();

        public Task<string> DoSomethingAsync() => Task.FromResult("Boo");

        public IDisposable? GetDisposable() => null;
    }
}
