﻿using MusicMarket.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicMarket.Core.Repositories
{
    public interface IArtistRepository:IRepository<Artist>
    {
        Task<IEnumerable<Artist>> GetAllWithMusics();
        Task<Artist> GetWithMusicsById(int id);
    }
}
