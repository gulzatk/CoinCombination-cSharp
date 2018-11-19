using System;
using System.Collections.Generic;

class CoinCombination
{
  private int _quarter = 0;
  private int _dime = 0;
  private int _nickel = 0;
  private int _penny = 0;

// public CoinCombination(int quarter, int dime, int nickel, int penny)
// {
//   _quarter = quarter;
//   _dime = dime;
//   _nickel = nickel;
//   _penny = penny;
// }
  public void TotalCoins(int inputCoins)
  {
    while (inputCoins > 0)
    {
      if (inputCoins>=25)
      {
        inputCoins = inputCoins-25;
        _quarter++;
      }
      else if (inputCoins>=10 && inputCoins<25)
      {
        inputCoins = inputCoins-10;
        _dime++;
      }
      else if (inputCoins>=5 && inputCoins<10)
      {
        inputCoins=inputCoins-5;
        _nickel++;
      }
      else if (inputCoins>=1 && inputCoins<5)
      {
        inputCoins= inputCoins-1;
        _penny++;
      }
    }
  }
  public int GetQuarter()
  {
    return _quarter;
  }
  public int GetDimes()
  {
    return _dime;
  }
  public int GetNickels()
  {
    return _nickel;
  }
  public int GetPenny()
  {
    return _penny;
  }
}
public class Program
{

  public static void Main()
  {
    CoinCombination totalCoinAmount = new CoinCombination();
    Console.WriteLine("Enter an amound of cents: ");
    int centCount = int.Parse(Console.ReadLine());
    totalCoinAmount.TotalCoins(centCount);

    Console.WriteLine("Your change is: ");
    Console.WriteLine("Quarters: " + totalCoinAmount.GetQuarter());
    Console.WriteLine("Dimes: " + totalCoinAmount.GetDimes());
    Console.WriteLine("Nickels: " + totalCoinAmount.GetNickels());
    Console.WriteLine("Pennies: " + totalCoinAmount.GetPenny());
  }

}
