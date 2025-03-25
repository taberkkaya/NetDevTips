namespace DataAccess.Models;

public sealed class PerfomanceLog
{
    public int Id { get; set; }
    public string MethodName { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TransactionTimeInSecond { get; set; }
    public int TransactionTimeInMilisecond { get; set; }
}
