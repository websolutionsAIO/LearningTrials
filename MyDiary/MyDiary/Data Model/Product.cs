using System;

namespace MyDiary
{
	public class Fee : ModelObject {
		string name;
		int unitPrice;

		public Fee(string name, int unitPrice) {
			this.name = name;
			this.unitPrice = unitPrice;
		}

		public string PayeeName {
			get { return name; }
			set { name = value; }
		}

		public int UnitPrice {
			get { return unitPrice; }
			set { unitPrice = value; }
		}
	}
}

