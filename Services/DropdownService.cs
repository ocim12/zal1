public interface IDropdownService
{
    List<Brand> ListOfBrands();
    List<Model> ListOfModels(Guid brandId);
}

public class DropdownService : IDropdownService
{
    private readonly ICarBrandService _brandService;

    public DropdownService(ICarBrandService brandService)
    {
        this._brandService = brandService;
    }
    public List<Brand> ListOfBrands()
    {
        throw new NotImplementedException();
    }

    public List<Model> ListOfModels(Guid brandId)
    {
        throw new NotImplementedException();
    }
}