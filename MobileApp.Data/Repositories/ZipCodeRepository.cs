using MobileApp.Data.Context;
using System.Linq;

namespace MobileApp.Data.Repositories
{
    public class ZipCodeRepository : IZipCodeRepository
    {
        MobileAppDbContext _db;

        public ZipCodeRepository(MobileAppDbContext db)
        {
            _db = db;
        }

        public bool Check(int zipCode)
        {
            return _db.TblNeighborhood.FirstOrDefault(p => p.IPostaCodeName == zipCode) != null;
        }
    }
}
