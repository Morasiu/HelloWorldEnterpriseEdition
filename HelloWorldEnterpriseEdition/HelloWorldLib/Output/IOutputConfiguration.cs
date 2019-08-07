namespace HelloWorldLib.Output {
	/// <summary>
	/// Base for all configuration options.
	/// </summary>
	internal interface IOutputConfiguration {
		/// <summary>
		/// Type of output for printing
		/// </summary>
		OutputType OutputType { get; }
	}
}