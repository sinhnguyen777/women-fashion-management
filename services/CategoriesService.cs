using Repositories.CategoriesRepository;
using WomemFashionManagement.Models;

namespace Services.CategoriesService
{
  public class CategoriesService
  {
    private readonly CategoriesRepository _categoriesRepository;

    public CategoriesService()
    {
      _categoriesRepository = new CategoriesRepository();
    }

    public List<Category> GetAllCategories()
    {
      return _categoriesRepository.GetAllCategories();
    }

    public Category GetCategoryById(int id)
    {
      return _categoriesRepository.GetCategoryById(id);
    }

    public List<Category> GetCategoriesByName(string name)
    {
      return _categoriesRepository.GetCategoriesByName(name);
    }
  }
}
