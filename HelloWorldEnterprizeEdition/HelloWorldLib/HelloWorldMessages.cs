using System.Collections.Generic;

namespace HelloWorldLib {
	public class HelloWorldMessages {
		public static Dictionary<Language, string> Messages = new Dictionary<Language, string>() {
			{ Language.English, "Hello, World!" },
			{ Language.Polish, "Hejka, świecie!" },
		};
	}
}