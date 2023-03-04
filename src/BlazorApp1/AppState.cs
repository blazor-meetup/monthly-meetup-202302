namespace BlazorApp1
{
    public class AppState
    {
        public int count = 0;
        public event Action? OnChange;

        public void increaseCount()
        {
            count++;
            NotifyStateChanged();
        }

        public void decreaseCount()
        {
            count--;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
