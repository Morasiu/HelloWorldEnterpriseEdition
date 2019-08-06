using System.Collections.Generic;
using HelloWorldLib;

namespace HelloWorldLib {
	public class HelloWorldMessages {
		public static Dictionary<Language, string> Messages = new Dictionary<Language, string>() {
			{ Language.English, "Hello, World!" },
			{ Language.Polish, "Hejka, świecie!" },
		};
	}
}