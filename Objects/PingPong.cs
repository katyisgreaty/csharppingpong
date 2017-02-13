using System;

namespace PingPong.Objects
{
  public class PingPong
  {

  //   public int _multiple;
   //
    public int _number;
    public List<string> _list;
  //   public int[] numberArray;
   //
    public PingPong(int number)
    {
      _number = number;
    }
   //
  //     for (int start = 0; start < _number; start++) {
   //
  //       if (multiple % 5 == 0)
  //       {
  //         numberArray[start] = "pong";
  //       } else if (multiple % 3 == 0)
  //       {
  //         numberArray[start] = "ping";
  //       } else
  //       {
  //         numberArray[start] = start;
  //       }
   //
  //     }
   //

    public List<string> PrintArray()
    {

        return _list;

    }


  }
}
