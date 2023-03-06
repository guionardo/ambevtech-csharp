namespace API;

public sealed class WorkerA : IHostedService
{
    private Task _task;

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _task = Run(cancellationToken);
        _task.Start();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("A STOPPED");
    }

    private static Task Run(CancellationToken token)
    {
        return new Task(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("A TICK");
            }
        });
    }
}