using System;

namespace MyDiary
{
	public class Order : ModelObject {

		DateTime date;
		bool shipped;
		Fee product;
		int quantity;

		public Order() {
			this.date = DateTime.Today;
			this.shipped = false;
			this.product = new Fee ("", 0);
			this.quantity = 0;
		}

		public Order(DateTime date, bool shipped, Fee product, int quantity) {
			this.date = date;
			this.shipped = shipped;
			this.product = product;
			this.quantity = quantity;
		}

		public DateTime PaymentDate
        {
			get { return date; }
			set { if (date != value) {
					date = value;
					RaisePropertyChanged("Date");}}
		}

		public bool Shipped {
			get { return shipped; }
			set { if(shipped != value) {
					shipped = value;
					RaisePropertyChanged("Shipped");}}
		}

		public Fee Fee {
			get { return product; }
			set { if (product != value) {
					product = value; 
					RaisePropertyChanged ("Fee");}}
		}

		public int FeeAmount
        {
			get { return quantity; }
			set { if (quantity != value) {
					quantity = value; 
					RaisePropertyChanged ("Quantity");}}
		}
	}
}

