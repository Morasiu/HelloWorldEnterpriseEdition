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

		public FluentConsoleConfiguration WithColor(ConsoleColor color) {
			Configuration.PrintColor = color;
			return this;
		}

		public HelloWorldBuilder Configure() => _helloWorldBuilder;
	}
}