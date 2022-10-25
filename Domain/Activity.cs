namespace Domain;

public class Activity
{
    public Guid Id { get; set; }
    public string? Title { get; init; }
    public DateTime? Date { get; init; }
    public string? Description { get; init; }
    public string? Category { get; init; }
    public string? City { get; init; }
    public string? Venue { get; init; }
}