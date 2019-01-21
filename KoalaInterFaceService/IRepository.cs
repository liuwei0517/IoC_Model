using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq.Expressions;
using KoalaInterFaceModels;

namespace KoalaInterFaceService
{
    /// <summary>
    /// 所有数据操作基类接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        KoalaKnowDevEntities GetDbContext { get; }
        T Get(Expression<Func<T, bool>> predicate);
        List<T> GetList(Expression<Func<T, bool>> expression);
    }
}
