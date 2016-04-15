using System;

namespace productlist
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to the Product List");
			UI.inputType type = UI.promptForCommand ();

			switch (type) {
			case UI.inputType.create:
				Product.fromPrompt ();
				break;
			case UI.inputType.list:
				Storage.List ();
				break;
			case UI.inputType.dump:
				Storage.dump ();
				break;
			case UI.inputType.load:
				Storage.load ();
				break;
			}
		}

	}
}
