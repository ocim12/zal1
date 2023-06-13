public interface ICarBrandService
{
    public void FillDatabase();
    public Brand GetBrand(Guid Id);
    public List<Brand> GetAllBrands();
    public Task<Brand> AddBrand();
    public List<Model> GetModelsById(Guid id);
}

public class CarBrandService : ICarBrandService
{
    private readonly RentalAppContext db;
    public CarBrandService(RentalAppContext db)
    {
        this.db = db;
    }
    public Task<Brand> AddBrand()
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAllBrands()
    {
        return db.Brands.ToList();
    }

    public Brand GetBrand(Guid Id)
    {   
        return db.Brands.FirstOrDefault(e=>e.Id == Id);
    }

    public List<Model> GetModelsById(Guid id){
        return db.Models.Where(e=>e.BrandId == id).ToList();
    }

    public void FillDatabase()
    {
        ICollection<Brand> initBrands = new List<Brand>();
        initBrands.Add(new Brand{Name = "BMW", Model = new List<Model>{new Model{ModelName = "E60"}, new Model{ModelName = "E90"},new Model{ModelName = "F30"}}});
        initBrands.Add(new Brand{Name = "Audi", Model = new List<Model>{new Model{ModelName = "S3"}, new Model{ModelName = "RSQ8"},new Model{ModelName = "R8"}}});
        initBrands.Add(new Brand{Name = "Ford", Model = new List<Model>{new Model{ModelName = "Fiesta"}, new Model{ModelName = "Focus"},new Model{ModelName = "Kuga"}}});
        initBrands.Add(new Brand{Name = "Toyota", Model = new List<Model>{new Model{ModelName = "Corolla"}, new Model{ModelName = "Verso"},new Model{ModelName = "Cupra"}}});
        
        foreach(var item in initBrands){
            db.Add(item);
        }

        db.SaveChanges();
    }
}