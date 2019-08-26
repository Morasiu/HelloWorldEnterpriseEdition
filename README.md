[![Build Status](https://travis-ci.com/Morasiu/HelloWorldEnterpriseEdition.svg?branch=master)](https://travis-ci.com/Morasiu/HelloWorldEnterpriseEdition)

# Hello World Enterprise Edition
The simplest program done in the most complicated way.

## Roadmap

* Add ASCII animations
* Add multiple Colors in console

## Features

* Fluent using
* Event to hookup
* Unit tests
* Cloud build with Travis CI
* Full documentation in XML
* Multiple languages (English, Polish for now)
* Design Patterns:
	* Builder
	* Factory
	* Observator

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

## How to run?

Program:

Use `dotnet run` in console.

Tests:

Use `dotnet test` in console.
