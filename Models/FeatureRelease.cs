using System;

namespace managerTracker.Models
{
    public class FeatureRelease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ProjectReleaseId { get; set; }
    }
}
