public class Rental
{
    public Guid Id { get; set; }
    public ICollection<Car> Cars { get; set; }
}