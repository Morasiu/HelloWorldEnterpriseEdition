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
			.UseLanguage(Language.English)
			.PrintToConsole(configuration => configuration
				.WithForegroundColor(ConsoleColor.Cyan)
				.WithBackgroundColor(ConsoleColor.DarkGreen))
			.Build();
		hello.Print();
	}
}
```
