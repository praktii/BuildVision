namespace BuildVision.Contracts
{
    public enum BuildState
    {
        NotStarted = 0,
        InProgress = 1,
        Done = 2,
        Cancelled = 3,
        Failed = 4,
        ErrorDone = 5
    }
}
