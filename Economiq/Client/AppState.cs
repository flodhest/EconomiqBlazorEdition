namespace Economiq.Client
{
    public class AppState
    {
        public bool IsLoggedIn { get; private set; }
        public string PageTitle { get; private set; }
        
        public event Action OnStateChange;

        public void SetPageTitle(string title)
        {
            PageTitle = title;
            NotifyStateChanged();
        }

        public void SetUserLoggedIn()
        {
            IsLoggedIn = true;
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnStateChange?.Invoke();
    }
}
