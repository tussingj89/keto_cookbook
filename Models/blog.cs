using System.ComponentModel.DataAnnotations;

namespace RazorPagesBlog.Models;

public class Blog
{
    public int Id { get; set; }

    [Required]
    public string? blog { get; set; }
    public string catagory { get; set; }
}