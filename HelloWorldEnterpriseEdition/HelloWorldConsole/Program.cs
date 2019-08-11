using System;
using HelloWorldLib;

namespace HelloWorldConsole {
	class Program {
		static void Main(string[] args) {
			var hello = new HelloWorldBuilder()
				.UseLanguage(Language.English)
				.UseMessage("Hello there!")
				.PrintToConsole(configuration => configuration
					.WithForegroundColor(ConsoleColor.Cyan)
					.WithBackgroundColor(ConsoleColor.DarkGreen))
				.Build();
			hello.Print();
			
		}
	}
}