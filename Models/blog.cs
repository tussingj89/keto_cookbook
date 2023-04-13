using System.ComponentModel.DataAnnotations;

namespace RazorPagesblog.Models;

public class blog
{
    public int Id { get; set; }

    [Required]
    public string? blog { get; set; }
    public string catagory { get; set; }
}