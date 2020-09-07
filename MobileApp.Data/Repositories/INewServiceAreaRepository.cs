using MobileApp.Data.Models;

namespace MobileApp.Data.Repositories
{
    public interface INewServiceAreaRepository
    {
        public void Add(TblNewServiceArea nsa);

        public bool Exists(string postCode);

    }
}
