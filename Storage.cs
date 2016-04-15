using System;
using System.Collections.Generic;

namespace productlist
{
	public static class Storage
	{
		private static List<Product> productStorageList = new List<Product>();

		public static void Add(Product p) {
			productStorageList.Add (p);
		}

		private static void listProducts() {
			if (productStorageList.Count < 1) {
				Console.WriteLine ("No Products found!");
				return;
			}
			foreach (Product p in productStorageList) {
				p.display ();
			}
		}

		public static void List() {
			listProducts ();
		}
	}
}

