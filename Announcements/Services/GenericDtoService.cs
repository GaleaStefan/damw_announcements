using Announcements.Repositories;
using AutoMapper;

namespace Announcements.Services;

public interface IGenericDtoService<TDto> where TDto : class
{
    #region Public members
    bool Delete(Guid id);
    bool Edit(Guid id, TDto newValues);
    IReadOnlyList<TDto> GetAll();
    TDto? GetById(Guid id);
    #endregion
}

public abstract class GenericDtoService<TEntity, TDto, TRepo> : IGenericDtoService<TDto>
    where TRepo : IGenericRepository<TEntity> where TEntity : class where TDto : class
{
    #region Fields
    protected readonly IMapper Mapper;
    protected readonly TRepo Repository;
    #endregion

    #region Constructors
    protected GenericDtoService(TRepo repository, IMapper mapper)
    {
        Repository = repository;
        Mapper = mapper;
    }
    #endregion

    #region Interface Implementations
    public bool Delete(Guid id)
    {
        return Repository.Delete(id);
    }

    public bool Edit(Guid id, TDto newValues)
    {
        var entity = Repository.GetById(id);
        if (entity == null)
            return false;
        Mapper.Map(newValues, entity);
        return true;
    }

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
