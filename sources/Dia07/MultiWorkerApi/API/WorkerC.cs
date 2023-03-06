namespace API;

public sealed class WorkerC : BaseWorker
{
    public WorkerC() : base("C", TimeSpan.FromSeconds(2))
    {
    }
}