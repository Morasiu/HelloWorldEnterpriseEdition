namespace HelloWorldLib {
	/// <summary>
	/// Repository, which contains all "Hello, World!" messages in different languages.
	/// </summary>
	public class HelloWorldMessageRepository {
		public string GetMessage(Language language = Language.English)
			=> HelloWorldMessages.Messages[language];
	}

	/// <summary>
	/// Contains all supported languages.
	/// </summary>
	public enum Language {
		English,

		Polish
		// TODO More languages
	}
}