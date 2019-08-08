using System;
using FluentAssertions;
using HelloWorldLib;
using Xunit;

namespace HelloWorldLibTests {
	public class HelloWorldTests {
		[Fact]
		public void WhenThereIsNoOutputConfigured_ThrowApplicationException() {
			//Arrange
			var helloWorld = new HelloWorldBuilder().Build();
			//Act
			Action print = () => helloWorld.Print();
			//Assert
			print.Should().Throw<ApplicationException>();
		}

		[Fact]
		public void WhenPrintIsCalled_RaiseOnPrintEvent() {
			//Arrange
			var message = "Hello, World!";
			var helloWorld = new HelloWorldBuilder()
				.UseMessage(message)
				.PrintToConsole()
				.Build();
			string messageFromEvent = null;
			helloWorld.OnPrint += (sender, args) => messageFromEvent = args.Message;
			//Act
			helloWorld.Print();
			//Assert
			messageFromEvent.Should().BeEquivalentTo(message);
		}
	}
}