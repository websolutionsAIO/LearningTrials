using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyDiary
{
	public abstract class OrdersRepository {
		readonly ObservableCollection<Order> orders;

		public OrdersRepository() {
			this.orders = new ObservableCollection<Order>();
		}

		//public ObservableCollection<Order> Orders {
		//	get { return orders; }
		//}

        public ObservableCollection<Order> FeeInfo
        {
            get { return orders; }
        }
    }

	public class TestOrdersRepository : OrdersRepository {

		const int orderCount = 100;
		readonly List<Fee> products;
		readonly Random random;

		public TestOrdersRepository() : base() {
			this.random = new Random((int)DateTime.Now.Ticks);
			this.products = new List<Fee>();

			GenerateProducts();

			for (int i = 0; i < orderCount; i++)
                FeeInfo.Add(GenerateOrder(i));
		}

		Order GenerateOrder(int number) {
			Order order = new Order(new DateTime(2014, 1, 1).AddDays(random.Next(0, 60)), 
				number % 3 == 0, RandomItem<Fee>(products), random.Next(1, 100));
			return order;
		}

		T RandomItem<T>(IList<T> list) {
			int index = (int)(random.NextDouble() * 0.99 * (list.Count));
			return list[index];
		}

		void GenerateProducts() {
			products.Add(new Fee("Tofu", 50));
			products.Add(new Fee("Chocolade", 34));
			products.Add(new Fee("Ikura", 70));
			products.Add(new Fee("Chai", 3));
			products.Add(new Fee("Boston Crab Meat", 36));
			products.Add(new Fee("Ravioli Angelo", 18));
			products.Add(new Fee("Ipon Coffee", 10));
			products.Add(new Fee("Questo Cabrales", 25));
		}
	}
}

