using CascadingDropdown.Models;
using CascadingDropdown.Services.Interface;

namespace CascadingDropdown.Services;

public class VideoGameService : IVideoGameService
{
  private List<PlatformModel> _platforms = new ()
  { 
    new PlatformModel{ Id = 1, Name = "PC"},
    new PlatformModel{ Id = 2, Name = "Xbox Series X"},
    new PlatformModel{ Id = 3, Name = "PlayStation 5"}
  };

  private List<GenreModel> _genres = new()
  {
    new GenreModel{ Id = 1, Name = "Action", PlatformId = 1},
    new GenreModel{ Id = 2, Name = "Moving", PlatformId = 1},
    new GenreModel{ Id = 3, Name = "RPG", PlatformId = 2},
    new GenreModel{ Id = 4, Name = "Sports", PlatformId = 2},
    new GenreModel{ Id = 5, Name = "Adventure", PlatformId = 3}
  };

  private List<VideoGameModel> _videoGames = new()
  {
    /**/
    new VideoGameModel{ Id = 1, Title = "The Witcher 3: Wild Hunt", PlatformId= 1, GenreId = 1 },
    new VideoGameModel{ Id = 2, Title = "Cyberpunk 2077", PlatformId= 1, GenreId = 2 },

    /**/
    new VideoGameModel{ Id = 3, Title = "Gran Turismo 7", PlatformId= 2, GenreId = 1 },
    new VideoGameModel{ Id = 4, Title = "NHL 24", PlatformId= 2, GenreId = 4 },

    /**/
    new VideoGameModel{ Id = 5, Title = "Return to Monkey Island", PlatformId= 3, GenreId = 5 },
    new VideoGameModel{ Id = 6, Title = "It takes Two", PlatformId= 3, GenreId = 1 }
  };

  public Task<List<GenreModel>> GetGenresByPlatformIdAsync(int platformId)
  {
    var genresByPlatformId = _genres.Where(w => w.PlatformId == platformId);
    return Task.FromResult(genresByPlatformId.ToList());
  }

  public Task<List<PlatformModel>> GetPlatformsAsync()
  {
    return Task.FromResult(_platforms);
  }

  public Task<List<VideoGameModel>> GetVideoGamesByPlatformAndGenreAsync(int platformId, int genreId)
  {
    var videoGamesList = _videoGames.Where(w => 
      w.PlatformId == platformId && 
      w.GenreId == genreId);

    return Task.FromResult(videoGamesList.ToList());
  }
}
