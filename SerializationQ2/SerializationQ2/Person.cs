using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace SerializationQ2
{
    [Serializable]
    public class Person
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

            XmlSerializer xmlserializer = new XmlSerializer(typeof(Person));
            Stream fs = new FileStream(@"C:\training\Eurotraining\CsharpApplns\SerializationQ1\SerializationQ1\person.txt", FileMode.OpenOrCreate, FileAccess.Write);
            xmlserializer.Serialize(fs, person);

            fs.Close();
            fs = new FileStream(@"C:\training\Eurotraining\CsharpApplns\SerializationQ1\SerializationQ1\person.txt", FileMode.Open,FileAccess.Read);
            TextReader reader = new StreamReader(fs);
            Person person1 = (Person)xmlserializer.Deserialize(reader);
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
