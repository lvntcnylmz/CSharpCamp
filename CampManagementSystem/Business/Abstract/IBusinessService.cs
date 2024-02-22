namespace Business.Abstract;

public interface IBusinessService<T>
{
    List<T> GetAll();
    T? GetById(int categoryId);
    void Add(T category);
    void Update(T category);
    void Delete(T category);
}