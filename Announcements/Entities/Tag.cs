using System.ComponentModel.DataAnnotations;

namespace Announcements.Entities;

public class Tag
{
    #region Properties and Indexers
    public Guid Id { get; set; }

    [Required]
    public string Text { get; set; }
    #endregion
}
