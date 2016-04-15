using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace productlist
{
	public static class Storage
	{
		private static List<Product> productStorageList = new List<Product>();
		private static readonly string filePath = @"data.json";

		public static void Add(Product p) {
			productStorageList.Add (p);
		}

		public static void dump() {
			if (productStorageList.Count < 1) {
				Console.WriteLine ("Nothing to dump");
				return;
			}
			string json = JsonConvert.SerializeObject (productStorageList);
			System.IO.File.WriteAllText (filePath, json);

		}

		public static void load() {
			if (!System.IO.File.Exists (filePath)) {
				Console.WriteLine ("Data file not found!");
				return;
			}
			string text = System.IO.File.ReadAllText (filePath);
			productStorageList = JsonConvert.DeserializeObject<List<Product>> (text);
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

