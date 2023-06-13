interface IRentalService{
    public Task<ICollection<Rental>> GetAllRentals();
    public Task<Rental> GetRental(Guid id);
}

class RentalService : IRentalService
{
    public Task<ICollection<Rental>> GetAllRentals()
    {
        throw new NotImplementedException();
    }

    public Task<Rental> GetRental(Guid id)
    {
        throw new NotImplementedException();
    }
}