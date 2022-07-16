
using GroceryShopping.API.DatabaseEF.Context;


namespace GroceryShopping.API.Models.Domain.Repository
{
   
        public abstract class BaseRepository
        {
            protected readonly AppDbContext _context;

            public BaseRepository(AppDbContext context)
            {
                _context = context;
            }
        }
    }

