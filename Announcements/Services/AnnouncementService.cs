using Announcements.DTOs;
using Announcements.Entities;
using Announcements.Repositories;
using AutoMapper;

namespace Announcements.Services;

public interface IAnnouncementService : IDtoService<AnnouncementDto>
{
}

public class AnnouncementService : DtoService<Announcement, AnnouncementDto, IAnnouncementRepository>,
    IAnnouncementService
{
    #region Constructors
    public AnnouncementService(IAnnouncementRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
    #endregion
}
