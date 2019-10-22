using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace RegionalVIC.Models.DB
{
    public class Helper
    {
        public static string GetRDSConnectionString()
        {
          //  var appConfig = System.Configuration.ConfigurationManager.AppSettings;

            string dbname = "regionaldb";

          //  if (string.IsNullOrEmpty(dbname)) return null;

            string username = "admin";
            string password = "zhaohf225";
            string hostname = "regionaldb.ccpxedmwa2fo.ap-southeast-2.rds.amazonaws.com";
            string port = "1433";

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
