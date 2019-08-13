[![Build Status](https://travis-ci.com/Morasiu/HelloWorldEnterpriseEdition.svg?branch=master)](https://travis-ci.com/Morasiu/HelloWorldEnterpriseEdition)

# Hello World Enterprise Edition
The simplest program done in the most complicated way.

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
