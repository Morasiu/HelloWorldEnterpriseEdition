using System;
using HelloWorldLib.Factories;
using HelloWorldLib.Output;

namespace HelloWorldLib.Consoles {
	internal class ConsoleOutputConfiguration : IOutputConfiguration, IDisposable {
		private ConsoleColor _foregroundColor;
		private ConsoleColor _backgroundColor;
		internal ConsoleOutputConfiguration() : this(ConsoleColor.White, ConsoleColor.Black) { }

		internal ConsoleOutputConfiguration(ConsoleColor foregroundColor, ConsoleColor backgroundColor) {
			ForegroundColor = foregroundColor;
			BackgroundColor = backgroundColor;
			OutputType = OutputType.Console;
			Printer = new PrinterFactory().CreateConsolePrinter(foregroundColor, backgroundColor);
		}

		public OutputType OutputType { get; }
		public IOutputPrinter Printer { get; }

		public ConsoleColor ForegroundColor {
			get => _foregroundColor;
			internal set {
				_foregroundColor = value;
				if (Printer is ConsolePrinter printer) printer.ForegroundColor = value;
			}
		}

		public ConsoleColor BackgroundColor {
			get => _backgroundColor;
			internal set {
				_backgroundColor = value;
				if (Printer is ConsolePrinter printer) printer.BackgroundColor = value;
			}
		}

		public void Dispose() {
			Printer.Dispose();
		}
	}
}