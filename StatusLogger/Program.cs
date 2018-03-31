using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogger {
    class Program {
        static void Main(string[] args) {

            StatusChangeLogger scl = new StatusChangeLogger();

            Item item = new Item() {
                Id = 0,
                ItemName = "Takamine Guitar",
                ItemStatus = ItemConstants.Statuses.InStock
            };

            item.ItemStatusChanged += scl.ItemStatusChanged;

            Console.WriteLine($"{item.ItemName}\n{item.ItemStatus}\n\n");
            Console.ReadKey();

            item.ItemStatus = ItemConstants.Statuses.Discounted;

            Console.WriteLine($"{item.ItemName}\n{item.ItemStatus}\n\n");
            Console.ReadKey();
        }
    }
}
