using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingForDuplicatesInAListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CS_ElevenDoubleValue> persons = new List<CS_ElevenDoubleValue>();

            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 42987.9,
                Value3 = 0.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 65199.4,
                Value3 = 25.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 97172.7,
                Value3 = 50.0
            }); // Is a dupe
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 147412.5,
                Value3 = 76.87
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 195115.9,
                Value3 = 100.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.0,
                Value2 = 245115.9,
                Value3 = 125.0
            });

            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 56324.8,
                Value3 = 0.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 75891.9,
                Value3 = 25.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 105212.6,
                Value3 = 50.0
            }); // Is a dupe
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 142450.2,
                Value3 = 76.87
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 176952.3,
                Value3 = 100.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.1,
                Value2 = 206952.3,
                Value3 = 125.0
            });
            persons.Add(new CS_ElevenDoubleValue
            {
                Value1 = 0.2,
                Value2 = 54172.1,
                Value3 = 0.0
            });

            var duplicatedSSN =
            from p in persons
            group p by p.Value1 into g
            where g.Count() > 1
            select g.Key;

            double standard = persons[0].Value1;
            var duplicated = persons.FindAll(p => p.Value1 == standard); // Value1이 같은 값들 찾기
            var duplicated2 = persons.FindAll(p => p.Value1 != standard); // Value1이 다른 값들 찾기

            duplicated2.ForEach(dup => persons.Remove(dup));

            Console.WriteLine("Value1이 같은 값들 찾기");
            for (int i = 0; i < duplicated.Count; i++)
            {
                Console.WriteLine("{0} {1}", duplicated[i].Value2.ToString(), duplicated[i].Value3.ToString());
            }

            Console.WriteLine("Value1이 다른 값들 찾기");
            var result = from value in persons
                         where value.Value1 == 0.2
                         group value by value.Value1;

            foreach (var value in result)
            {
                foreach (var item in value)
                {
                    Console.WriteLine("{0} {1}", item.Value2, item.Value3);
                }
            }

            Console.ReadKey();
        }
    }

    public class CS_ElevenDoubleValue
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Value3 { get; set; }
        public double Value4 { get; set; }
        public double Value5 { get; set; }
        public double Value6 { get; set; }
        public double Value7 { get; set; }
        public double Value8 { get; set; }
        public double Value9 { get; set; }
        public double Value10 { get; set; }
        public double Value11 { get; set; }
    }

}
