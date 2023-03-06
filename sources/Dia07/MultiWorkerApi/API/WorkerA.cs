namespace API;

public sealed class WorkerA : BaseWorker
{
    public WorkerA() : base("A", TimeSpan.FromSeconds(1))
    {
    }
}