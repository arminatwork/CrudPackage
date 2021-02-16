using api.Data.Context;
using api.Models;

using Crud.BaseRepository;

namespace api.Data.Repositories
{
    public class DeveloperRepository : BaseRepository<Developer>, IDeveloperRepository
    {
        private readonly AppDbContext _context;

        public DeveloperRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}