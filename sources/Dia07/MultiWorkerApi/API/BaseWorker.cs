namespace API;

public class BaseWorker : IHostedService
{
    private readonly TimeSpan _interval;
    private readonly string _name;
    private Task _task;

    protected BaseWorker(string name, TimeSpan interval)
    {
        _name = name;
        _interval = interval;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"Starting worker {_name}");
        _task = Run(cancellationToken);
        _task.Start();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine($"Stopping worker {_name}");
    }

    private Task Run(CancellationToken token)
    {
        return new Task(() =>
        {
            while (!token.IsCancellationRequested)
            {
                Thread.Sleep(_interval);
                Console.WriteLine($"TICK {_name}");
            }
        });
    }
}