using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
            static void Main(string[] args)
            {
                double whiskeyPrice = double.Parse(Console.ReadLine());
                double beer = double.Parse(Console.ReadLine());
                double wine = double.Parse(Console.ReadLine());
                double rakia = double.Parse(Console.ReadLine());
                double whiskey = double.Parse(Console.ReadLine());
                double rakiaLprice = whiskeyPrice / 2;
                double wineLprice = rakiaLprice - (0.4 * rakiaLprice);
                double beerLprice = rakiaLprice - (0.8 * rakiaLprice);
                double rakiaprice = rakia * rakiaLprice;
                double wineprice = wine * wineLprice;
                double beerprice = beerLprice * beer;
                double whiskeyprice = whiskey * whiskeyPrice;
                double cost = rakiaprice + wineprice + beerprice + whiskeyprice;
                Console.WriteLine("{0:F2}", cost);
            }
        }
    }


