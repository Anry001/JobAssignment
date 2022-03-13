using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFeedReader
{//run the application from here
    class ConsoleUI
    {
        public static void Run()
        {
            STORE feed = XMLDeserializer.Deserializer(new STORE());
            feed.PrintNumberOfProductsInFeed();
            feed.PrintTheMostExpensiveProductDetails();
        }
    }
}
