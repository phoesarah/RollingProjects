using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUtilities
{
    public class GenericList<T> 
    {
        private T[] innerList;

        public GenericList()
        {
            innerList = new T[0];
        }

        public GenericList(T[] passedInArray)
        {
            innerList = new T[passedInArray.Length];
            passedInArray.CopyTo(innerList, 0);
        }
    }
}
