using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogDemo
{
    public interface IService<T>
    {
        void Add(T t);
        T Get(int id);

        bool Remove(T t);

        List<T> All();



    }
}
