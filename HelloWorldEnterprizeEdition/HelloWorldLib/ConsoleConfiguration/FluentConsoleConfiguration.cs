using System;

namespace HelloWorldLib.ConsoleConfiguration {
	public class FluentConsoleConfiguration {
		private readonly HelloWorldBuilder _helloWorldBuilder;
		internal ConsoleOutputConfiguration Configuration;
		internal FluentConsoleConfiguration(HelloWorldBuilder helloWorldBuilder) {
			_helloWorldBuilder = helloWorldBuilder;
			Configuration = new ConsoleOutputConfiguration();
			_helloWorldBuilder._outputConfigurations.Add(Configuration);
		}

		public FluentConsoleConfiguration WithForegroundColor(ConsoleColor color) {
			Configuration.ForegroundColor = color;
			return this;
		}

		public FluentConsoleConfiguration WithBackgroundColor(ConsoleColor color)
		{
			Configuration.BackgroundColor = color;
			return this;
		}

		public HelloWorldBuilder Configure() => _helloWorldBuilder;
	}
}