using Bulky.DataAccess.Repository.IRepository;
using RailPen.Data;
using RailPen.Models;

namespace Bulky.DataAccess.Repository
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        private Context _db;
        public MemberRepository(Context db) : base(db)
        {
            _db = db;
        }

        public void Update(Member obj)
        {
            _db.Members.Update(obj);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}