using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldLib.ConsoleConfiguration;
using HelloWorldLib.Output;

namespace HelloWorldLib {
	/// <summary>
	/// Builder for <see cref="HelloWorld"/>
	/// </summary>
	public class HelloWorldBuilder  {
		#region Private variables

		private Language _language = Language.English;
		private readonly HelloWorldMessageRepository _helloWorldMessageRepository;
		private string _message;
		internal readonly List<IOutputConfiguration> _outputConfigurations;

		#endregion

		public HelloWorldBuilder() {
			_helloWorldMessageRepository = new HelloWorldMessageRepository();
			_outputConfigurations = new List<IOutputConfiguration>();
		}

		/// <summary>
		/// Build new <see cref="HelloWorld"/> based on fluent building.
		/// </summary>
		/// <returns></returns>
		public HelloWorld Build() {
			var helloWorld = new HelloWorld(_outputConfigurations) {
				MessageLanguage = _language,
				Message = _message,
			};
			return helloWorld;
		}

		/// <summary>
		/// Specifies which language should be used. Default is <see cref="Language.English"/>
		/// If Message is not specified it will use default message from <see cref="HelloWorldMessageRepository"/>
		/// </summary>
		/// <param name="language">Message language</param>
		/// <returns></returns>
		public HelloWorldBuilder UseLanguage(Language language) {
			_language = language;
			if(_message == null)
				_message = _helloWorldMessageRepository.GetMessage(_language);
			return this;
		}
		/// <summary>
		/// Message to print.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		public HelloWorldBuilder UseMessage(string message) {
			_message = message;
			return this;
		}

		public FluentConsoleConfiguration PrintToConsole() {
			if(_outputConfigurations.Any(o => o.OutputType == OutputType.Console)) throw new ArgumentException("Console output is already specified.");
			return new FluentConsoleConfiguration(this);
		}
	}



	/// <summary>
	/// Output which ca be use for print
	/// </summary>
	public enum OutputType {
		/// <summary>
		/// Output of console window
		/// </summary>
		Console
	}
}