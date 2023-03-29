using Announcements.Repositories;
using AutoMapper;

namespace Announcements.Services;

public interface IDtoService<out TDto> where TDto : class
{
    #region Public members
    IReadOnlyList<TDto> GetAll();
    TDto? GetById(Guid id);
    #endregion
}

public abstract class DtoService<TEntity, TDto, TRepo> : IDtoService<TDto>
    where TRepo : IGenericRepository<TEntity> where TEntity : class where TDto : class
{
    #region Fields
    protected readonly IMapper Mapper;
    protected readonly TRepo Repository;
    #endregion

    #region Constructors
    protected DtoService(TRepo repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }
    #endregion

    #region Interface Implementations
    public IReadOnlyList<TDto> GetAll()
    {
        return Repository.GetAll()
            .Select(e => Mapper.Map<TEntity, TDto>(e))
            .ToList();
    }

    public TDto? GetById(Guid id)
    {
        var entity = Repository.GetById(id);
        return entity == null ? null : Mapper.Map<TEntity, TDto>(entity);
    }
    #endregion
}
