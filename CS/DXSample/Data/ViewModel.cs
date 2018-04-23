using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXSample {
    public class ViewModel {

        public ObservableCollection<SimpleData> Collection { get; set; }
        
        public ViewModel() {
            Random rand = new Random();
            Collection = new ObservableCollection<SimpleData>();
            for (int i = 0; i < 100; i++) {
                Collection.Add(new SimpleData() { 
                    ID = i,
                    Name = "Name"+i,
                    Description = "Description" + i,
                    Price = rand.Next(0, 10000) / rand.Next(1, 10),
                    Count = rand.Next(0, 1000)
                });
            }
        }
    }
}