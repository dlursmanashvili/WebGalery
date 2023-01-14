using System.Linq.Expressions;

namespace WebGallery.DTO.Interfaces;
public interface IRepositoryBase<TModel> where TModel : class
{
    TModel Get(Expression<Func<TModel, bool>> expression);
    IEnumerable<TModel> GetAll();
    IEnumerable<TModel> GetAll(Expression<Func<TModel, bool>> expression);
    void Add(TModel entity);
    void AddRange(IEnumerable<TModel> entities);
    void Remove(TModel entity);
    void RemoveRange(IEnumerable<TModel> entities);
    void Update(TModel entity);
    void UpdateRange(IEnumerable<TModel> entities);
    void MyAddTransaction(TModel model);
    void MyDeleteTransaction(TModel model);
    void MyUpdateTransaction(TModel model);
}
