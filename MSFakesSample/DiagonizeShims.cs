﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFakesSample
{
    public class DiagonizeShims
    {
        public static void DoomsDay()
        {
            if (DateTime.Now.Equals(new DateTime(2012, 12, 21)))
            {
                throw new Exception("Time's Up!!! World will end now");
            }

            // other code
        }

        public static void DeleteTemporaryData(string dirLocation)
        {
            Directory.Delete(dirLocation, true);
        }

        public string GetEventName(ILogger logger)
        {
            if (logger.IsLoggerEnabled)
            {
                logger.Log("GetEventName method is called.");
            }

            return "Sample Event";
        }
    }
}
