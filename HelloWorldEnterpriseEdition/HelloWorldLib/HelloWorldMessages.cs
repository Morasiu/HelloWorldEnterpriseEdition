using System.Collections.Generic;

namespace HelloWorldLib {
	/// <summary>
	/// All messages in static object.
	/// TODO Support for file and database storage
	/// </summary>
	public class HelloWorldMessages {
		public static readonly Dictionary<Language, string> Messages = new Dictionary<Language, string>() {
			{ Language.English, "Hello, World!" },
			{ Language.Polish, "Hejka, świecie!" },
		};
	}
}