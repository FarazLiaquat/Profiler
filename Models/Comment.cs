using System.ComponentModel.DataAnnotations;

namespace Profiler.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Name { get; set; }
        [Display(Name ="Comment Date")]
        public DateTime CommentDate { get; set; }
        public string Body { get; set; }
        public string Email { get; set; }
        [EmailAddress]

    }
}
