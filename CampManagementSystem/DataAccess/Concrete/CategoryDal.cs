using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    private readonly List<Category> _categories = [
        new Category(1, "Backend"),
        new Category(2, "Frontend"),
        new Category(3, "Full Stack"),
    ];

    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category? GetById(int categoryId)
    {
        return _categories.Find(c => c.Id == categoryId);
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Update(Category category)
    {
        var categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
        if (categoryToUpdate != null)
        {
            categoryToUpdate.Name = category.Name;
        }
    }

    public void Delete(Category category)
    {
        var categoryToDelete = GetById(category.Id);
        if (categoryToDelete != null) _categories.Remove(categoryToDelete);
    }
}