using CascadingDropdown.Models;

namespace CascadingDropdown.Services.Interface;

public interface IVideoGameService
{
  Task<List<PlatformModel>> GetPlatformsAsync();
  Task<List<GenreModel>> GetGenresByPlatformIdAsync(int platformId);
  Task<List<VideoGameModel>> GetVideoGamesByPlatformAndGenreAsync(int platformId, int genreId);
}
