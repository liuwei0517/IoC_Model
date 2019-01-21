using KoalaInterFaceModels;
using KoalaInterFaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceBLL
{
    public abstract class BaseBLL<T> : IRepository<T> where T : class
    {
        public KoalaKnowDevEntities GetDbContext => throw new NotImplementedException();

        public abstract T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        public abstract List<T> GetList(Expression<Func<T, bool>> expression);
    }
}
