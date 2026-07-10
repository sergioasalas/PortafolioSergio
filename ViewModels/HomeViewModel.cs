using PortafolioSergio.Models;

namespace PortafolioSergio.ViewModels;

public class HomeViewModel
{
    public required IReadOnlyList<ProjectItem> Projects { get; init; }
    public required IReadOnlyList<string> Technologies { get; init; }
}
