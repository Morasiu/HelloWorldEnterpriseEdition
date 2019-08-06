using System;
using HelloWorldLib;

namespace HelloWorldConsole {
	class Program {
		static void Main(string[] args) {
			var hello = new HelloWorldBuilder()
				.UseMessage("No hej")
				.UseLanguage(Language.Polish)
				.PrintToConsole()
					.WithColor(ConsoleColor.Cyan)
					.Configure()
				.Build();
			hello.Print();
		}
	}
}