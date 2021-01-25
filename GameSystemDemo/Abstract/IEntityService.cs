using GameSystemDemo.Concrete;
using GameSystemDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSystemDemo.Abstract
{
    public interface IEntityService<T> where T:class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
