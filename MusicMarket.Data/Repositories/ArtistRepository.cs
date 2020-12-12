using Microsoft.EntityFrameworkCore;
using MusicMarket.Core.Models;
using MusicMarket.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarket.Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicMarketDbContext context) : base(context)
        {

        }
        public Task<IEnumerable<Artist>> GetAllWithMusics()
        {
            
            throw new NotImplementedException();
        }

        public Task<Artist> GetWithMusicsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
