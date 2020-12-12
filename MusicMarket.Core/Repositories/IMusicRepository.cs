using MusicMarket.Core.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicMarket.Core.Repositories
{
    public interface IMusicRepository:IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<Music> GetWithArtistById(int id);
        Task<IEnumerable<Music>> GetAllwithArtistByArtistId(int artistId);
    }
}
