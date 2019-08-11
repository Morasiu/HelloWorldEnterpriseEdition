using HelloWorldLib.Consoles;

namespace HelloWorldLib.Output {
	/// <summary>
	/// Base for all configuration options.
	/// </summary>
	internal interface IOutputConfiguration {
		/// <summary>
		/// Type of output for printing
		/// </summary>
		OutputType OutputType { get; }
		/// <summary>
		/// Printer used for printing.
		/// </summary>
		IOutputPrinter Printer { get; }
	}
}