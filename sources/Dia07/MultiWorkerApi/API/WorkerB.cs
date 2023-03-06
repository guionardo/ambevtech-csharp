namespace API;

public sealed class WorkerB : BaseWorker
{
    public WorkerB() : base("B", TimeSpan.FromSeconds(1.5))
    {
    }
}