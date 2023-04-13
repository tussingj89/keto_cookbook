using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecipes.Models;

public class Recipes
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