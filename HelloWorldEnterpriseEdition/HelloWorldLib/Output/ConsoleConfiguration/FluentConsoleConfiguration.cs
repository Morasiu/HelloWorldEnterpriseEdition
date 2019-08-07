using System;

namespace HelloWorldLib.Output.ConsoleConfiguration {
	public class FluentConsoleConfiguration {
		internal ConsoleOutputConfiguration Configuration;

		internal FluentConsoleConfiguration() {
			Configuration = new ConsoleOutputConfiguration();
		}

		public FluentConsoleConfiguration WithForegroundColor(ConsoleColor color) {
			Configuration.ForegroundColor = color;
			return this;
		}

		public FluentConsoleConfiguration WithBackgroundColor(ConsoleColor color) {
			Configuration.BackgroundColor = color;
			return this;
		}
	}
}