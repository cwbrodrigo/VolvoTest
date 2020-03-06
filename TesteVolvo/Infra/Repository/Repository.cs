using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TesteVolvo.Domain;
using TesteVolvo.Domain.Interfaces;

namespace TesteVolvo.Infra.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly VolvoContext context = new VolvoContext();
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
