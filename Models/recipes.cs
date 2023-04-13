using System.ComponentModel.DataAnnotations;

namespace RazorPagesrecipes.Models;

public class recipes
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
    public string catagory { get; set; }
    public  string ingredients { get; set; }
    public string? directions { get; set;}

    [Range(0.0, 5.0)]
    public decimal rating { get; set;}
}