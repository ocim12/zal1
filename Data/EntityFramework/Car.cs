public class Car
{
    public Guid Id { get; set; }
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; } //price per day
    public bool IsAvailable { get; set; }
    public string? WhoRented { get; set; }

}