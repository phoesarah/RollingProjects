using ClassUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqyGoodness
{
    public class Examples
    {
        public void Example()
        {
            var doubleList = new List<double> { 3.2, 6.1 };

            var stringList = new List<string> { "Foo", "Bar", "Baz" };
            //var stringList = new List<int> { 3, 4, 5 };

            stringList
                .Select(x => x)
                .GroupBy(x => x.First());

            var orderList = new List<Order> { new SalesOrder(), new PurchaseOrder() };
        }

        public void PageExample()
        {
            var somethiign = new Dictionary<int, Dictionary<string, Tuple<double, decimal>>>()


            int pageSize = 25;
            int currentPage = 2;
            var intList = Enumerable.Range(0, 100).ToList();

            var pageOfList = Page(intList, 2, 25);
            //intList.Skip(25 * (currentPage - 1)).Take(pageSize);

            var stringList = new List<string>();
            Page(stringList, 2, 25);
        }

        public IEnumerable<T> Page<T>(IEnumerable<T> list, int currentPage, int pageSize)
        {
            return list.Skip(pageSize * (currentPage - 1)).Take(pageSize);
        }
    }

    public class Order
    {

    }

    public class SalesOrder : Order
    {

    }

    public class PurchaseOrder : Order
    {

    }
}
