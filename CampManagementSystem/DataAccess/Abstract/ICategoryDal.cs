using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category? GetById(int categoryId);
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}