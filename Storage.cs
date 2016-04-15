using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace productlist
{
	public static class Storage
	{
		private static readonly string filePath = @"data.json";

		public static void dump() {
			if (Product.allProducts.Count < 1) {
				Console.WriteLine ("Nothing to dump");
				return;
			}
			string json = JsonConvert.SerializeObject (Product.allProducts);
			System.IO.File.WriteAllText (filePath, json);

		}

		public static void load() {
			if (!System.IO.File.Exists (filePath)) {
				Console.WriteLine ("Data file not found!");
				return;
			}
			string text = System.IO.File.ReadAllText (filePath);
			Product.allProducts = JsonConvert.DeserializeObject<List<Product>> (text);
		}

		private static void listProducts() {
			if (Product.allProducts.Count < 1) {
				Console.WriteLine ("No Products found!");
				return;
			}
			foreach (Product p in Product.allProducts) {
				p.display ();
			}
		}

		public static void List() {
			listProducts ();
		}
	}
}

