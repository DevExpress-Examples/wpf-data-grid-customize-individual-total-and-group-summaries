using DevExpress.Mvvm;

namespace DXSample {
    public class SampleData : BindableBase {
        public string City { get; set; }
        public double Discount { get; set; }
        public double Freight { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
