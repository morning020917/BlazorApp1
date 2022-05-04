using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Pages;
public class TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; }
}