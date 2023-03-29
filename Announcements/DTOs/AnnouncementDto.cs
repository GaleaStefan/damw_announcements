namespace Announcements.DTOs;

public class AnnouncementDto
{
    #region Properties and Indexers
    public string Author { get; set; }
    public string Content { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    #endregion
}
