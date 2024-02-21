using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager(ICategoryDal categoryDal) : ICategoryService
{
    private readonly ICategoryDal _categoryDal = categoryDal;

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public Category? GetById(int categoryId)
    {
        return _categoryDal.GetById(categoryId);
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }
}