using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldLib.Consoles;
using HelloWorldLib.Output;

namespace HelloWorldLib {
	/// <summary>
	/// Main class for HelloWorld Lib.
	/// </summary>
	public class HelloWorld : IHelloWorld {
		#region Publics variables

		/// <summary>
		/// Language of the message.
		/// </summary>
		public Language MessageLanguage { get; internal set; }

		/// <summary>
		/// Language of the message.
		/// </summary>
		public string Message { get; internal set; }

		/// <summary>
		/// Event raised when message is printed.
		/// </summary>
		public event EventHandler<HelloWorldEventArgs> OnPrint;

		#endregion

		#region Private variables

		private readonly IEnumerable<IOutputConfiguration> _configurations;

		#endregion

		/// <summary>
		/// Creates new <see cref="HelloWorld"/>
		/// </summary>
		internal HelloWorld(IEnumerable<IOutputConfiguration> configurations) {
			_configurations = configurations;
		}

		#region Public methods

		/// <summary>
		/// Prints message to all outputs.
		/// </summary>
		public void Print() {
			if (!_configurations.Any()) throw new ApplicationException("No printing outputs configured");
			OnPrint?.Invoke(this, new HelloWorldEventArgs(Message));
			foreach (var configuration in _configurations) {
				switch (configuration.OutputType) {
					case OutputType.Console:
						configuration.Printer.Print(Message);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Interface for printing
	/// </summary>
	public interface IHelloWorld {
		/// <summary>
		/// Prints "Hello, World"
		/// </summary>
		void Print();
	}
}