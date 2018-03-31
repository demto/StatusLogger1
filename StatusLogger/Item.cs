using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogger {
    class Item {

        public int Id { get; set; }
        public string ItemName { get; set; }
        public event EventHandler<ItemStatusEventArgs> ItemStatusChanged;
        private ItemConstants.Statuses itemStatus;
        public ItemConstants.Statuses ItemStatus { 
            get { return itemStatus; } 
            set {
                if(value != itemStatus){
                    itemStatus = value;
                    OnItemStatusChanged(this.ItemName, this.ItemStatus);
                }
            }
        }

        protected virtual void OnItemStatusChanged(string itemName, ItemConstants.Statuses itemStatus) {
            ItemStatusChanged?.Invoke(this, new ItemStatusEventArgs(ItemName, itemStatus));
        }
    }
}
