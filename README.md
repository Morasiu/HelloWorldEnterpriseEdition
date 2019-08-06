# HelloWorldEnterprizeEdition
The most simple program done in the most complicated way.

## Roadmap

* Add ASCII animations
* Add multiple Colors in console


## How to use it?

```csharp
class Program {
	static void Main(string[] args) {
		var hello = new HelloWorldBuilder()
			.UseMessage("No hej")
			.UseLanguage(Language.Polish)
			.PrintToConsole()
				.WithForegroundColor(ConsoleColor.Cyan)
				.WithBackgroundColor(ConsoleColor.DarkGreen)
				.Configure()
			.Build();
		hello.Print();
	}
}
```
