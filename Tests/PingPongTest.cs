using Xunit;
namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void IsMultiple_IsMultipleOfThree_true()
    {
      //Arrange
      PingPong testPingPong = new PingPong(1);
      List<string> expected = new List<string>{"1"};
      //Act
      List<string> output = testPingPong.PrintArray();
      //Assert
      Assert.Equal(expected, output);
    }
  }
}
