namespace HelloWorldLib {
	public class HelloWorldMessageRepository {
		public string GetMessage(Language language = Language.English)
			=> HelloWorldMessages.Messages[language];
	}

	public enum Language {
		English,

		Polish
		// TODO More languages
	}
}