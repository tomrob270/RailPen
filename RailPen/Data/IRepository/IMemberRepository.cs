using RailPen.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IMemberRepository : IRepository<Member>
    {
        void Update(Member obj);
        void Save();
    }
}