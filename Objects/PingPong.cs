using System;
using System.Collections.Generic;

namespace PingPongApp.Objects
{
  public class PingPong
  {

  //   public int _multiple;
   //
    public int _number;

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

        List<string> listObj = new List<string>{};
        for (int i = 1; i <= _number; i++)
        {
          if (i % 3 ==0)
          {
            listObj.Add("ping".ToString());
          } else{
              listObj.Add(i.ToString());  
          }
        }


        return listObj;
    }


  }
}
