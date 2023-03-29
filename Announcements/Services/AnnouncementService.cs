using Announcements.DTOs;
using Announcements.Entities;
using Announcements.Repositories;
using AutoMapper;

namespace Announcements.Services;

public interface IAnnouncementService : IGenericDtoService<AnnouncementDto>
{
}

public class AnnouncementService : GenericDtoService<Announcement, AnnouncementDto, IAnnouncementRepository>,
    IAnnouncementService
{
    #region Constructors
    public AnnouncementService(IAnnouncementRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
    #endregion
}
