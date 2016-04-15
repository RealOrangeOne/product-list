using System;
using Newtonsoft.Json;

namespace productlist
{
	public class Product
	{
		public string name;
		public int version;
		public string description;

		public Product(string name, int version, string description) {
			this.name = name;
			this.version = version;
			this.description = description;
		}
		public static Product fromPrompt() {
			string pName = UI.getAnswer ("Product Name", UI.validateString);
			int pVersion = Int32.Parse(UI.getAnswer ("Version", UI.validateInt));
			string pDescription = UI.getAnswer ("Description", UI.validateString);
			Product p = new Product (pName, pVersion, pDescription);
			Console.WriteLine(String.Format("{0} created successfully!", p.ToString()));
			return p;
		}

		public override string ToString() {
			return String.Format ("Product {0}", this.name);
		}

		public string serialize() {
			return JsonConvert.SerializeObject (this);
		}

		public static Product fromJSON(string json) {
			return JsonConvert.DeserializeObject<Product> (json);
		}

		public void display() {
			string output = String.Format(@"
{0}
--------------------------
Name: {1}
Version: {2}
Description: {3}
			", this.ToString(), this.name, this.version, this.description);
			Console.WriteLine (output);
		}
	}
}
