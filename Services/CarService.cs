interface ICarService
{
    public Car GetCar(Guid id);
    public List<Car> GetAllCars();
    public Task AddCar(Car car);
    public Task DeleteCar(Car car);
    public Task EditCar(Car car);
}

class CarService : ICarService
{
    private readonly RentalAppContext db;
    public CarService(RentalAppContext db)
    {
        this.db = db;
    }

    public async Task AddCar(Car car)
    {
        db.Add(car);
        await db.SaveChangesAsync();
    }

    public async Task DeleteCar(Car car)
    {
        db.Cars.Remove(car);
        await db.SaveChangesAsync();
    }

    public async Task EditCar(Car car)
    {
        var carToEdit = GetCar(car.Id);

        carToEdit.Brand = car.Brand;
        carToEdit.Model = car.Model;
        carToEdit.Year = car.Year;
        carToEdit.Price = car.Price;
        carToEdit.IsAvailable = car.IsAvailable;
        carToEdit.WhoRented = car.WhoRented;

        await db.SaveChangesAsync();
    }

    public List<Car> GetAllCars()
    {
        return db.Cars.ToList();
    }

    public Car GetCar(Guid id)
    {   
        var carToReturn = db.Cars.FirstOrDefault(e=>e.Id == id);
        if(carToReturn == null){
            return new Car();
        }
        return carToReturn;
    }
}