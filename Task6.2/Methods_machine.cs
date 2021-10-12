using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
// Не кінцкевий варіант
namespace Task5._2
{
    class Methods_machine
    {
        public Dictionary<String, int> Ip_book = new Dictionary<string, int>();
        public List<One_ip> ip_objects = new List<One_ip>();
        int[] days = {0,0,0,0,0,0,0};
        public void add_data()
        {

            using (StreamReader file = new StreamReader(@"C:\Users\Ruslanchik\Desktop\data.txt"))
            {
                string ln;
                int counter=0;
                try
                {
                    while ((ln = file.ReadLine()) != null)
                {
                     One_ip temp = new One_ip(ln.Split(' ')[0], ln.Split(' ')[2]);
                     ip_objects.Add(temp);
                     finding_most_popular_day(ln.Split(' ')[2]);
                    counter++;
                    
                        if (Ip_book.ContainsKey(ln.Split(' ')[0]))
                        {
                            Ip_book[ln.Split(' ')[0]] = Ip_book[ln.Split(' ')[0]] + 1;
                            if (ln.Split(' ')[0].Split('.').Length != 4)
                            {
                                throw new Exception(string.Format("IP number {0} is wrong", counter));
                            }
                        }
                        else
                        {
                            Ip_book.Add(ln.Split(' ')[0], 1);

                        }
                   }
                    


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void finding_most_popular_day(string day)
        {
            switch (day)
            {
                case "monday":
                    days[0] += 1;
                    break;
                case "thuesday":
                    days[1] += 1;
                    break;
                case "wendesday":
                    days[2] += 1;
                    break;
                case "thursday":
                    days[3] += 1;
                    break;
                case "friday":
                    days[4] += 1;
                    break;
                case "saturday":
                    days[5] += 1;
                    break;
                case "sunday":
                    days[6] += 1;
                    break;
                default:
                    break;
            }
        } 
        public string most_popular_day()
        {
            int max_index = 0;
            for (int i = 0; i < days.Length; i++)
            {
                if (days[max_index] < days[i])
                {
                    max_index = i;
                }

            }

            switch (max_index)
            {
                case 0:
                    return "monday";
                    
                case 1:
                    return "thuesday";
                    
                case 2:
                    return "wendesday";
                    
                case 3:
                    return "thuesday";
                    
                case 4:
                    return "friday";
                    
                case 5:
                    return "saturday";
                    
                case 6:
                    return "sunday";
                    
                default:
                    return "error";
                    
            }


           
        }
    }



   
}
