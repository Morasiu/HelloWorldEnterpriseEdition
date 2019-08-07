using System;

namespace HelloWorldLib.Output.ConsoleConfiguration {
	class ConsoleOutputConfiguration : IOutputConfiguration {
		internal ConsoleOutputConfiguration() : this(ConsoleColor.White, ConsoleColor.Black) { }

		internal ConsoleOutputConfiguration(ConsoleColor foregroundColor, ConsoleColor backgroundColor) {
			ForegroundColor = foregroundColor;
			BackgroundColor = backgroundColor;
			OutputType = OutputType.Console;
		}

		public OutputType OutputType { get; }

		public ConsoleColor ForegroundColor { get; set; }
		public ConsoleColor BackgroundColor { get; set; }
	}
}