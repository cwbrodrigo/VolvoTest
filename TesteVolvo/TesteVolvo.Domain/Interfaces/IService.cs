using System;
using System.Collections.Generic;
using System.Text;

namespace TesteVolvo.Domain.Interfaces
{
	public interface IService<T> where T : BaseEntity
    {
        T Post<V>(T obj);

        T Put<V>(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
