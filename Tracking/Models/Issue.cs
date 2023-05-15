using System.ComponentModel.DataAnnotations;

namespace Tracking.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public IssueType IssueType { get; set; }
        public Priority Priority { get; set; }       
        public DateTime CreatedOn { get; set; }
        public DateTime? CompletedOn { get; set; }

       
    }

    public enum Priority
    {
        Low, Medium, High
    }

    public enum IssueType
    {
        Bug,
        Feature,
        Documentation
    }
}
