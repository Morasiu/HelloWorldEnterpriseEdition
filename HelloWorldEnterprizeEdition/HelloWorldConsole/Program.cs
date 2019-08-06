using System;
using HelloWorldLib;

namespace HelloWorldConsole {
	class Program {
		static void Main(string[] args) {
			var hello = new HelloWorldBuilder()
				.UseMessage("No hej")
				.UseLanguage(Language.Polish)
				.PrintToConsole()
					.WithForegroundColor(ConsoleColor.Cyan)
					.WithBackgroundColor(ConsoleColor.DarkGreen)
					.Configure()
				.Build();
			hello.Print();
		}
	}
}