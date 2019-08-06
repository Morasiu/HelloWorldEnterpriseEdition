using System;
using FluentAssertions;
using HelloWorldLib;
using Xunit;

namespace HelloWorldLibTests {
	public class HelloWorldMessageRepositoryTests {
		[Fact]
		public void WhenLanguageIsEnglish_ReturnEnglishMessage() {
			//Arrange
			var expectedMessage = HelloWorldMessages.Messages[Language.English];
			//Act
			var message = new HelloWorldMessageRepository().GetMessage(Language.English);
			//Assert
			message.Should().BeEquivalentTo(expectedMessage);
		}

		[Fact]
		public void WhenLanguageIsPolish_ReturnPolishMessage()
		{
			//Arrange
			var expectedMessage = HelloWorldMessages.Messages[Language.Polish];
			//Act
			var message = new HelloWorldMessageRepository().GetMessage(Language.Polish);
			//Assert
			message.Should().BeEquivalentTo(expectedMessage);
		}
	}
}