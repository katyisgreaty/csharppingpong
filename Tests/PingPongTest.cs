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
      PingPong testPingPong = new PingPong(15);
      List<string> expected = new List<string>{"1","2","ping","4","pong","ping", "7", "8", "ping","pong", "11","ping", "13", "14", "pingpong"};
      //Act
      List<string> output = testPingPong.PrintArray();
      //Assert
      Assert.Equal(expected, output);
    }
  }
}
