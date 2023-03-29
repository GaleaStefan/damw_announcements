using Announcements.DTOs;
using Announcements.Entities;
using AutoMapper;

namespace Announcements.Profiles;

// ReSharper disable once UnusedType.Global - used with reflection
public class DtoProfile : Profile
{
    #region Constructors
    public DtoProfile()
    {
        CreateMap<AnnouncementDto, Announcement>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<Announcement, AnnouncementDto>();
    }
    #endregion
}
