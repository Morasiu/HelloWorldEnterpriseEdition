using System;

namespace HelloWorldLib {
	/// <summary>
	/// EventArgs for <see cref="HelloWorld"/> event print.
	/// </summary>
	public class HelloWorldEventArgs : EventArgs {
		public HelloWorldEventArgs(string message) {
			Message = message;
		}
		/// <summary>
		/// Message printed by <see cref="HelloWorld"/>
		/// </summary>
		public string Message { get; }
	}
}