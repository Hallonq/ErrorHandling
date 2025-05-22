namespace ErrorHandling.Web.Services
{
    public class SlowService
    {
        public async Task DoSlowWorkAsync()
        {
            await Task.Delay(3000);
        }
    }
}
