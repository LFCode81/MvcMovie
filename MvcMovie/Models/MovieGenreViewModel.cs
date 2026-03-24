using Microsoft.AspNetCore.Mvc.Rendering;


namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public  Genre? MovieGenre { get; set; }
 
    public string? SearchString { get; set; }
}