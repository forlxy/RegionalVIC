using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionalVIC.Models
{
    public class colorDisplay
    {
        public int code;
        public string color;
        public string display;
        public double value;
        public colorDisplay()
        {
            code = 0;
            color = "#ddd";
            display = "No record";
            value = 0;
        }
        public colorDisplay(int code, string color, string display, double value = 0)
        {
            this.code = code;
            this.color = color;
            this.display = display;
            this.value = value;
        }


        // get color depending on house price value
        //public static string getAcomColor(int d)
        //{
        //    return d > 550 ? "#BF360C" :
        //        d > 450 ? "#E64A19" :
        //            d > 350 ? "#FF5722" :
        //                d > 300 ? "#FF8A65" :
        //                    d > 250 ? "#FFCCBC" :
        //                        d > 200 ? "#81C784" :
        //                            d > 150 ? "#4CAF50" :
        //                                d > 0 ? "#388E3C" :
        //                                    "#ddd";
        //}
        public static string getAcomColor(int d)
        {
            return d > 550 ? "#001D4B" :
                d > 450 ? "#003664" :
                    d > 350 ? "#00507E" :
                        d > 300 ? "#1583B1" :
                            d > 250 ? "#2E9CCA" :
                                d > 200 ? "#61CFFD" :
                                    d > 150 ? "#94FFFF" :
                                        d > 0 ? "#C7FFFF" :
                                            "#ddd";
        }
        // get color depending on criminal rate
        public static string getCrimeColor(decimal d)
        {
            return d > 10 ? "#001D4B" :
                d > 8 ? "#003664" :
                    d > 7 ? "#00507E" :
                        d > 6 ? "#1583B1" :
                            d > 5 ? "#2E9CCA" :
                                    d > 3 ? "#61CFFD" :
                                        d > 1 ? "#94FFFF" :
                                            d > 0 ? "#C7FFFF" :
                                                "#ddd";
        }

        // get color depending on population density value
        public static string getUnempColor(decimal d)
        {
            return d > 8 ? "#001D4B" :
                d > 7 ? "#003664" :
                    d > 6 ? "#00507E" :
                        d > 5 ? "#1583B1" :
                            d > 4 ? "#2E9CCA" :
                                d > 3 ? "#61CFFD" :
                                    d > 2 ? "#94FFFF" :
                                        d > 0 ? "#C7FFFF" :
                                            "#ddd";
        }

        // get color depending on population density value
        public static string getIncomeColor(decimal d)
        {
            return d > 60000 ? "#001D4B" :
                d > 55000 ? "#003664" :
                    d > 50000 ? "#00507E" :
                        d > 48000 ? "#1583B1" :
                            d > 440000 ? "#2E9CCA" :
                                d > 40000 ? "#61CFFD" :
                                    d > 35000 ? "#94FFFF" :
                                        d > 0 ? "#C7FFFF" :
                                            "#ddd";
        }
        // get color depending on population density value
        public static string getDesyColor(decimal d)
        {
            return d > 200 ? "#001D4B" :
                d > 50 ? "#003664" :
                    d > 20 ? "#00507E" :
                        d > 8 ? "#1583B1" :
                            d > 5 ? "#2E9CCA" :
                                d > 3 ? "#61CFFD" :
                                    d > 1 ? "#94FFFF" :
                                        d > 0 ? "#C7FFFF" :
                                            "#ddd";
        }
    }

}
