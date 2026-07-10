namespace PortafolioSergio.Models;

/// <summary>
/// Representa un proyecto mostrado dentro del portafolio.
/// </summary>
public class ProjectItem
{
    public required string Title { get; init; }
    public required string Description { get; init; }
    public required string ImageUrl { get; init; }
    public required IReadOnlyList<string> Technologies { get; init; }
    public string? RepositoryUrl { get; init; }
    public string? DemoUrl { get; init; }
    public string? Status { get; init; }
}
