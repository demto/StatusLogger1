using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogger {
    class ItemStatusEventArgs : EventArgs {

        public int Id { get; set; }
        public string ItemName { get; set; }
        public ItemConstants.Statuses ItemStatus { get; set; }

        public ItemStatusEventArgs(string itemName, ItemConstants.Statuses itemStatus) {
            this.ItemName = itemName;
            this.ItemStatus = itemStatus;
        }
    }
}
