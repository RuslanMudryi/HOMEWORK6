using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._2
{
    class One_ip
    {
        public string ip = "0.0.0.0";
        public Dictionary<String, int> day_was_visited = new Dictionary<string, int>();


        One_ip()
        {
            ip = "0.0.0.0";
            
            day_was_visited.Add("monday", 0);

        }
        public One_ip(string quant,string day)
        {
            ip = "0.0.0.0";
            
            day_was_visited.Add("monday", 0);

        }


    }
}
