using MobileApp.Data.Context;
using MobileApp.Data.Models;
using System.Linq;

namespace MobileApp.Data.Repositories
{
    public class NewServiceAreaRepository : INewServiceAreaRepository
    {
        private readonly MobileAppDbContext _db;

        public NewServiceAreaRepository(MobileAppDbContext db)
        {
            _db = db;
        }

        public void Add(TblNewServiceArea nsa)
        {
            _db.TblNewServiceArea.Add(nsa);
            _db.SaveChanges();
        }

        public bool Exists(string postCode)
        {
            return _db.TblNewServiceArea.FirstOrDefault(p => p.SPostaCodeName == postCode && p.BEnable == 1 && p.BArchive == 0) != null;
        }
    }
}
