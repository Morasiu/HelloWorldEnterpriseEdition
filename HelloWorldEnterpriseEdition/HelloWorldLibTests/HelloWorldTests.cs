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
	}
}