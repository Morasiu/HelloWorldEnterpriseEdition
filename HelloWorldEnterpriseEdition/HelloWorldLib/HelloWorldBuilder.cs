using System;
using System.Collections.Generic;
using System.Linq;
using HelloWorldLib.Output;
using HelloWorldLib.Output.ConsoleConfiguration;

namespace HelloWorldLib {
	/// <summary>
	/// Builder for <see cref="HelloWorld"/>
	/// </summary>
	public class HelloWorldBuilder  {
		#region Private variables

		private Language _language = Language.English;
		private readonly HelloWorldMessageRepository _helloWorldMessageRepository;
		private string _message;

		#endregion

		internal readonly List<IOutputConfiguration> OutputConfigurations;

		public HelloWorldBuilder() {
			_helloWorldMessageRepository = new HelloWorldMessageRepository();
			OutputConfigurations = new List<IOutputConfiguration>();
		}

		/// <summary>
		/// Build new <see cref="HelloWorld"/> based on fluent building.
		/// </summary>
		/// <returns></returns>
		public HelloWorld Build() {
			var helloWorld = new HelloWorld(OutputConfigurations) {
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

		/// <summary>
		/// Configure console printing
		/// </summary>
		/// <param name="configureConsole"></param>
		/// <returns></returns>
		public HelloWorldBuilder PrintToConsole(Action<FluentConsoleConfiguration> configureConsole = null) {
			if(OutputConfigurations.Any(o => o.OutputType == OutputType.Console)) throw new ArgumentException("Console output is already specified.");
			var consoleConfiguration = new FluentConsoleConfiguration();
			configureConsole?.Invoke(consoleConfiguration);
			OutputConfigurations.Add(consoleConfiguration.Configuration);
			return this;
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