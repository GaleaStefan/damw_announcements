﻿namespace Announcements.Models;

public class AnnouncementTag
{
    #region Properties and Indexers
    public Announcement Announcement { get; set; }
    public Tag Tag { get; set; }
    #endregion
}
