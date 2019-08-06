using System;
using HelloWorldLib.Output;

namespace HelloWorldLib.ConsoleConfiguration {
	class ConsoleOutputConfiguration : IOutputConfiguration {
		internal ConsoleOutputConfiguration() : this(ConsoleColor.White){
		} 
		internal ConsoleOutputConfiguration(ConsoleColor printColor) {
			PrintColor = printColor;
			OutputType = OutputType.Console;
		}
		public OutputType OutputType { get; }

		public ConsoleColor PrintColor { get; set; }
	}
}