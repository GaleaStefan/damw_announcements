using System.ComponentModel.DataAnnotations;

namespace Announcements.Entities;

public class Announcement
{
    #region Properties and Indexers
    public IList<AnnouncementTag> AnnouncementTags { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public Category Category { get; set; }

    [Required]
    public string Content { get; set; }

    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; }
    #endregion
}
