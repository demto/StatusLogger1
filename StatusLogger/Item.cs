using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogger {
    class Item {

        public int Id { get; set; }
        public string ItemName { get; set; }
        public EventHandler<EventArgs> ItemStatusChanged;
        private ItemConstants itemStatus;
        public ItemConstants ItemStatus { 
            get { return itemStatus; } 
            set {
                if(value != itemStatus){
                    itemStatus = value;
                    OnItemStatusChanged(this.ItemName, this.ItemStatus);
                }
            }
        }

        protected void OnItemStatusChanged(string itemName, ItemConstants itemStatus){
            ItemStatusChanged?.Invoke(this, new EventArgs());
    }
}
