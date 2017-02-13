using Xunit;
using System.Collections.Generic;
using PingPongApp.Objects;

namespace PingPongApp
{
  public class PingPongTest
  {
    [Fact]
    public void IsMultiple_IsMultipleOfThree_true()
    {
      //Arrange
      PingPong testPingPong = new PingPong(3);
      List<string> expected = new List<string>{"1","2","ping"};
      //Act
      List<string> output = testPingPong.PrintArray();
      //Assert
      Assert.Equal(expected, output);
    }
  }
}
