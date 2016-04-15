using System;

namespace productlist
{
	public static class UI
	{
		public enum inputType {
			create,
			delete,
			list,
			help,
			dump,
			load
		}
		private static inputType decodeInputType(string input) {
			string command = input.Split (null, 1)[0];
			switch (command.ToLower()) {
			case "create":
				return inputType.create;
			case "delete":
				return inputType.delete;
			case "list":
				return inputType.list;
			default:
			case "help":
				return inputType.help;
			case "dump":
				return inputType.dump;
			case "load":
				return inputType.load;
			}
		}

		public static bool validateInt(string input) {
			int result;
			return Int32.TryParse (input, out result);
		}

		public static bool validateString (object input) {
			return input is string;
		}

		public static string getAnswer(string prompt, Func<string, bool> validator) {
			string input;
			do {
				Console.Write(prompt + ": ");
				input = Console.ReadLine();
			} while (!validator (input));
			return input;
		}

		public static inputType promptForCommand() {
			Console.Write ("Enter command: ");
			string command = Console.ReadLine ();
			return decodeInputType (command);
		}
	}
}

