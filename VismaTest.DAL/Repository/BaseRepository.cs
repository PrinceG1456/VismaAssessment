using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VismaTest.DAL.IRespository;
using VismaTest.DAL.Store;

namespace VismaTest.DAL.Repository
{
    public class BaseRepository
    {
        protected readonly IDataContext _context;

        public BaseRepository(IDataContext context)
        {
            _context = context;
        }
    }
}
