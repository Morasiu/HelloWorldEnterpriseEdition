using System;
using System.IO;

namespace HelloWorldLib {
	/// <summary>
	/// Main class for HelloWorld Lib.
	/// </summary>
	public class HelloWorld {
		#region Publics

		/// <summary>
		/// Creates new <see cref="HelloWorld"/>
		/// </summary>
		public HelloWorld() {
			_helloWorldMessageRepository = new HelloWorldMessageRepository();
		}

		/// <summary>
		/// Prints message to <see cref="Console.Out"/>
		/// </summary>
		public void Print() {
			var message = _helloWorldMessageRepository.GetMessage();
			Console.WriteLine(message);
		}

		#endregion

		#region Privates

		private readonly HelloWorldMessageRepository _helloWorldMessageRepository;

		#endregion
	}
}