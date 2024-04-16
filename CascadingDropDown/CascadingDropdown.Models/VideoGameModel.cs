namespace CascadingDropdown.Models;

public class VideoGameModel
{
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public int PlatformId {  get; set; }
  public int GenreId { get; set; }
}
