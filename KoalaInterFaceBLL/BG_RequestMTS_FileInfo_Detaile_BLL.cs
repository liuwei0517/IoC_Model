using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KoalaInterFaceBLL
{
    public class BG_RequestMTS_FileInfo_Detaile_BLL<T> : BaseBLL<T> where T:class
    {
        public override T Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<T> GetList(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
