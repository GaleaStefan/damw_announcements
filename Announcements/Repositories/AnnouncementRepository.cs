using Announcements.Entities;

namespace Announcements.Repositories;

public interface IAnnouncementRepository : IGenericRepository<Announcement>
{
}

public class AnnouncementRepository : GenericRepository<Announcement>, IAnnouncementRepository
{
    #region Fields
    private readonly List<Announcement> _announcements = new()
    {
        new Announcement { Author = "test", Content = "test", Title = "test" }
    };
    #endregion

    #region Interface Implementations
    public override IEnumerable<Announcement> GetAll()
    {
        return _announcements;
    }

    public override Announcement? GetById(Guid id)
    {
        return _announcements.FirstOrDefault(a => a.Id == id);
    }
    #endregion
}
