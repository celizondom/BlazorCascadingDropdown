using CascadingDropdown.BusinessLogic.Interface;
using CascadingDropdown.Models;
using CascadingDropdown.Services.Interface;

namespace CascadingDropdown.BusinessLogic;

public class VideoGameBusinessLogic : IVideoGameBusinessLogic
{
  private readonly IVideoGameService _videoGameService;

  public VideoGameBusinessLogic(IVideoGameService videoGameService)
  {
    _videoGameService = videoGameService ?? throw new ArgumentNullException(nameof(videoGameService));
  }
  public Task<List<GenreModel>> GetGenresByPlatformIdAsync(int platformId)
  {
    if (platformId < 1)
    {
      throw new ArgumentException(nameof(platformId), "Parameters values should be major than 0");
    }

    return _videoGameService.GetGenresByPlatformIdAsync(platformId);
  }

  public Task<List<PlatformModel>> GetPlatformsAsync()
  {
    return _videoGameService.GetPlatformsAsync();
  }

  public Task<List<VideoGameModel>> GetVideoGamesByPlatformAndGenreAsync(int platformId, int genreId)
  {
    if(platformId < 1 || genreId < 1)
    {
      throw new ArgumentException(nameof(platformId),"Parameters values should be major than 0");
    }

    return _videoGameService.GetVideoGamesByPlatformAndGenreAsync(platformId, genreId);
  }
}
