using System;

namespace HelloWorldLib.Output {
	/// <summary>
	/// Base for all printers
	/// </summary>
	public interface IOutputPrinter : IDisposable {
		/// <summary>
		/// Print message using output
		/// </summary>
		/// <param name="message"></param>
		void Print(string message);
	}
}