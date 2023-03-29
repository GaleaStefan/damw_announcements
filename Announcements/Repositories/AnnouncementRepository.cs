using Announcements.Entities;

namespace Announcements.Repositories;

public interface IAnnouncementRepository : IGenericRepository<Announcement>
{
}

public class AnnouncementRepository : GenericRepository<Announcement>, IAnnouncementRepository
{
    #region Static Fields and Constants
    private static readonly List<Announcement> Announcements = new()
    {
        new Announcement { Id = Guid.NewGuid(), Author = "test", Content = "test", Title = "test" },
        new Announcement { Id = Guid.NewGuid(), Author = "test2", Content = "test2", Title = "test2" }
    };
    #endregion

    #region Interface Implementations
    public override bool Delete(Guid id)
    {
        var existing = GetById(id);
        if (existing == null)
            return false;
        Announcements.Remove(existing);
        return true;
    }

    public override IEnumerable<Announcement> GetAll()
    {
        return Announcements;
    }

    public override Announcement? GetById(Guid id)
    {
        return Announcements.FirstOrDefault(a => a.Id == id);
    }
    #endregion
}
