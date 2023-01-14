using System.Linq.Expressions;
using WebGallery.DTO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WebGallery.Repositories;

public class RepositoryBase<TModel> : IRepositoryBase<TModel> where TModel : class
{
    public readonly MyDbContext _dbContext;
    private DbSet<TModel> _entitiySet;

    public RepositoryBase(MyDbContext dbContext)
    {
        _dbContext = dbContext;
        _entitiySet = _dbContext.Set<TModel>();
    }

    public TModel Get(Expression<Func<TModel, bool>> expression)
        => _entitiySet.First(expression);

    public IEnumerable<TModel> GetAll()
        => _entitiySet.AsEnumerable();

    public IEnumerable<TModel> GetAll(Expression<Func<TModel, bool>> expression)
        => _entitiySet.Where(expression).AsEnumerable();

    public void Add(TModel entity)
        => _dbContext.Add(entity);

    public void AddRange(IEnumerable<TModel> entities)
        => _dbContext.AddRange(entities);

    public void Remove(TModel entity)
        => _dbContext.Remove(entity);

    public void RemoveRange(IEnumerable<TModel> entities)
        => _dbContext.RemoveRange(entities);


    public void Update(TModel entity)
        => _dbContext.Update(entity);


    public void UpdateRange(IEnumerable<TModel> entities)
        => _dbContext.UpdateRange(entities);

    public void MyAddTransaction(TModel model)
    {
        var mytransaction = _dbContext.Database.BeginTransaction();
        try
        {
            _entitiySet.Add(model);
            _dbContext.SaveChanges();
            mytransaction.Commit();
        }
        catch (Exception)
        {

            mytransaction.Rollback();
        }

    }

    public void MyDeleteTransaction(TModel model)
    {
        var mytransaction = _dbContext.Database.BeginTransaction();
        try
        {
            _entitiySet.Remove(model);
            _dbContext.SaveChanges();
            mytransaction.Commit();
        }
        catch (Exception)
        {
            mytransaction.Rollback();
        }

    }

    public void MyUpdateTransaction(TModel model)
    {
        var mytransaction = _dbContext.Database.BeginTransaction();
        try
        {
            _entitiySet.Update(model);
            _dbContext.SaveChanges();
            mytransaction.Commit();
        }
        catch (Exception)
        {

            mytransaction.Rollback();
        }

    }
}
