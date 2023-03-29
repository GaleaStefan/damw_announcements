using Announcements.DTOs;
using Announcements.Services;
using Microsoft.AspNetCore.Mvc;

namespace Announcements.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnnouncementsController : Controller
{
    #region Fields
    private readonly IAnnouncementService _announcementService;
    #endregion

    #region Constructors
    public AnnouncementsController(IAnnouncementService announcementService)
    {
        _announcementService = announcementService;
    }
    #endregion

    #region Public members
    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        return _announcementService.Delete(id) ? Ok() : NotFound();
    }

    [HttpPut]
    public IActionResult Edit([FromBody] AnnouncementDto newValues)
    {
        return _announcementService.Edit(newValues.Id, newValues) ? Ok() : NotFound();
    }

    [HttpGet]
    public IReadOnlyList<AnnouncementDto> GetAll()
    {
        return _announcementService.GetAll();
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var dto = _announcementService.GetById(id);
        if (dto == null)
            return NotFound();
        return Ok(dto);
    }
    #endregion
}
