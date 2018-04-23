using DevExpress.Mvvm;

namespace DXSample {
    public class SimpleData : BindableBase {
        public string City { get; set; }
        public double Discount { get; set; }
        public double Freight { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
