using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializationQ1
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public City City { get; set; }
        City c = new City();
        public override string ToString()
        {
           
            StringBuilder str = new StringBuilder();
            str.AppendLine("Name: " + Name);
            str.AppendLine("Age: " + Age);
            str.AppendLine("City: " + c.Name);
            return str.ToString();
        }

        public void CreatePerson()
        {
            

            Person person = new Person() { Name = "Nauj", Age = 26, City = new City() { Name = "Spain", Population = 13456766 } };

            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\training\Eurotraining\CsharpApplns\SerializationQ1\SerializationQ1\person.txt", FileMode.OpenOrCreate, FileAccess.Write);
            binaryFormatter.Serialize(fs, person);

            fs.Close();
            fs = new FileStream(@"C:\training\Eurotraining\CsharpApplns\SerializationQ1\SerializationQ1\person.txt", FileMode.Open, FileAccess.Read);
            Person person1 = (Person)binaryFormatter.Deserialize(fs);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.City.Name);
        }

    }

   

[Serializable]
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
