namespace API;

public sealed class WorkerB : IHostedService
{
    private Task _task;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _task = Run(cancellationToken);
        _task.Start();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("B STOPPED");
    }

    private static Task Run(CancellationToken token)
    {
        return new Task(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1.5));
                Console.WriteLine("B TICK");
            }
        });
    }
}