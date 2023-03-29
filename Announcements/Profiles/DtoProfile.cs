using Announcements.DTOs;
using Announcements.Entities;
using AutoMapper;

namespace Announcements.Profiles;

public class DtoProfile : Profile
{
    #region Constructors
    public DtoProfile()
    {
        CreateMap<AnnouncementDto, Announcement>()
            .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => Guid.NewGuid())
            );
    }
    #endregion
}
