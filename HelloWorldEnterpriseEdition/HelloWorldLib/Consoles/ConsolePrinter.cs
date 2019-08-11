using System;
using HelloWorldLib.Output;

namespace HelloWorldLib.Consoles {
	/// <summary>
	/// Printer used for console printing.
	/// </summary>
	public class ConsolePrinter : IOutputPrinter {
		internal ConsoleColor ForegroundColor;
		internal ConsoleColor BackgroundColor;

		public ConsolePrinter(ConsoleColor backgroundColor, ConsoleColor foregroundColor) {
			BackgroundColor = backgroundColor;
			ForegroundColor = foregroundColor;
		}

		/// <summary>
		/// Print message using <see cref="Console.WriteLine()"/> and given colors.
		/// </summary>
		/// <param name="message">Message to print</param>
		public void Print(string message) {
			Console.BackgroundColor = BackgroundColor;
			Console.ForegroundColor = ForegroundColor;
			Console.WriteLine(message);
		}

		/// <summary>
		/// Reset console colors.
		/// </summary>
		public void Dispose() {
			Console.ResetColor();
		}
	}
}