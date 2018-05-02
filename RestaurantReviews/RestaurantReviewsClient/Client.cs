using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewsLibrary;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace RestaurantReviewsClient
{
    class Client
    {
        static void Main(string[] args)
        {
            Logger log = LogManager.GetCurrentClassLogger();
            UserInteractor user = new UserInteractor();
            while (!user.OptionHandler())
            {
                
            }
            log.Trace("Program exited");
            
        }
    }
}
