using System;
using System.Collections.Generic;
using System.Text;
using TesteVolvo.Domain;
using TesteVolvo.Domain.Interfaces;
using TesteVolvo.Infra.Repository;

namespace Services_
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private Repository<T> repository = new Repository<T>();

        public T Post<V>(T obj)
        {
            repository.Insert(obj);
            return obj;
        }

        public T Put<V>(T obj)
        {
            repository.Update(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can't be zero.");

            repository.Remove(id);
        }

        public IList<T> SelectAll() => repository.SelectAll();

        public T Select(int id)
        {
            if (id == 0)
                throw new ArgumentException("Id não pode ser 0.");

            return repository.Select(id);
        }
    }
}
