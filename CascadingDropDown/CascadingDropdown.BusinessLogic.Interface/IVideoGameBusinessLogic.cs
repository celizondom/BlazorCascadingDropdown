using CascadingDropdown.Models;

namespace CascadingDropdown.BusinessLogic.Interface;

public interface IVideoGameBusinessLogic
{
  Task<List<PlatformModel>> GetPlatformsAsync();
  Task<List<GenreModel>> GetGenresByPlatformIdAsync(int platformId);
  Task<List<VideoGameModel>> GetVideoGamesByPlatformAndGenreAsync(int platformId, int genreId);
}
