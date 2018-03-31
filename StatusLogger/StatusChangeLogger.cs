using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusLogger {
    class StatusChangeLogger {

        public DateTime LogTime { get; set; }
        public string Log { get; set; }
        public Item Item { get; set; }

        public StatusChangeLogger() {
            this.Item = null;
            this.LogTime = DateTime.Now;
            this.Log = "";
        }

        public void ItemStatusChanged(object sender, ItemStatusEventArgs e){
            DirectoryInfo newDir = Directory.CreateDirectory(@"C:\MyStuff\AppLogs");
            string filePath = @"C:\MyStuff\AppLogs\Log";

            Log = $"{DateTime.Now} - Item : {e.ItemName}'s status changed to : {e.ItemStatus}";
            using(StreamWriter sr = new StreamWriter(filePath)){
                sr.WriteLine(Log);
            }
        }
    }
}
