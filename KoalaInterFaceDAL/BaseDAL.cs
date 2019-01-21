using KoalaInterFaceModels;
using KoalaInterFaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceDAL
{
    public abstract class BaseDAL<T> : IRepository<T> where T : class
    {
        public BaseDAL()
        {

        }

        public KoalaKnowDevEntities GetDbContext => new KoalaKnowDevEntities();

        KoalaKnowDevEntities IRepository<T>.GetDbContext => throw new NotImplementedException();


        T IRepository<T>.Get(Expression<Func<T, bool>> predicate)
        {
            using (KoalaKnowDevEntities kke = this.GetDbContext)
            {
                return kke.Set<T>().FirstOrDefault(predicate);
            }
        }

        List<T> IRepository<T>.GetList(Expression<Func<T, bool>> expression) 
        {
            using (KoalaKnowDevEntities kke = this.GetDbContext)
            {
                return kke.Set<T>().Where(expression).ToList();
            }
        }
    }
}
