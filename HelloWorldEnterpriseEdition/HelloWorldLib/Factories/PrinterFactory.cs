using System;
using HelloWorldLib.Consoles;

namespace HelloWorldLib.Factories {
	/// <summary>
	/// Creates different printers
	/// </summary>
	public class PrinterFactory : IPrinterFactory {
		public ConsolePrinter CreateConsolePrinter(ConsoleColor backgroundColor, ConsoleColor foregroundColor) 
			=> new ConsolePrinter(backgroundColor, foregroundColor);
	}

	public interface IPrinterFactory {
		ConsolePrinter CreateConsolePrinter(ConsoleColor backgroundColor, ConsoleColor foregroundColor);
	}
}