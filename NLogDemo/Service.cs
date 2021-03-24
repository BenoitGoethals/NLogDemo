using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogDemo
{
    public class Service<T> : IService<T> where T:ItemBase
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private SortedSet<T> items = new SortedSet<T>();
        public void Add(T t)
        {
            items.Add(t);
            logger.Info($"{t} added");
        }

        public List<T> All()
        {
            return items.ToList<T>();
        }

        public T Get(int id)
        {
           return items.FirstOrDefault<T>(t => t.Id.Equals(id));
        }

        public bool Remove(T t)
        {
            try
            {
                var ret = items.Remove(t);
                return ret;
            }
            catch (Exception ex)
            {

                logger.Error(ex,"error");
              
            }
            return false;

        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}
