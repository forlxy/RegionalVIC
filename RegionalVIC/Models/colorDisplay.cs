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
        public colorDisplay()
        {
            code = 0;
            color = "#ddd";
            display = "No record";
        }
        public colorDisplay(int code, string color, string display)
        {
            this.code = code;
            this.color = color;
            this.display = display;
        }

        // get color depending on house price value
        public static string getAcomColor(int d)
        {
            return d > 550 ? "#723122" :
                d > 450 ? "#8B4225" :
                    d > 350 ? "#A25626" :
                        d > 300 ? "#B86B25" :
                            d > 250 ? "#CA8323" :
                                d > 200 ? "#E6B71E" :
                                    d > 150 ? "#EED322" :
                                        d > 50 ? "#F2F12D" :
                                            "#ddd";
        }
        // get color depending on criminal rate
        public static string getCrimeColor(decimal d)
        {
            return d > 10 ? "#723122" :
                d > 8 ? "#8B4225" :
                    d > 7 ? "#A25626" :
                        d > 6 ? "#B86B25" :
                            d > 5 ? "#CA8323" :
                                d > 4 ? "#DA9C20" :
                                    d > 3 ? "#E6B71E" :
                                        d > 2 ? "#EED322" :
                                            d > 1 ? "#F2F12D" :
                                                "#ddd";
        }

        // get color depending on population density value
        public static string getDesyColor(decimal d)
        {
            return d > 200 ? "#723122" :
                d > 50 ? "#8B4225" :
                    d > 20 ? "#A25626" :
                        d > 8 ? "#B86B25" :
                            d > 5 ? "#CA8323" :
                                d > 3 ? "#E6B71E" :
                                    d > 1 ? "#EED322" :
                                        d > 0 ? "#F2F12D" :
                                            "#ddd";
        }
        
    }

}
