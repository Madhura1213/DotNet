 internal class Program
    {
        static void Main(string[] args)
        {
            // Serialize Emp class with XML serialization
            Emp emp = new Emp
            {
                Id = 1,
                Name = "John Doe",
                Department = "IT"
            };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Emp));
            using (FileStream xmlFile = new FileStream(@"C:\Users\IET\source\repos\SerializaAssign\MyData1.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(xmlFile, emp);
            }

            Console.WriteLine("Emp class serialized with XML using FileStream.");

            // Serialize Customer class with SOAP
            Customer customer = new Customer
            {
                Id = 1001,
                Name = "Alice",
                Email = "alice@example.com"
            };

            SoapFormatter sf = new SoapFormatter();
            //XmlSerializer soapxmlSerializer = new XmlSerializer(typeof(Customer));
            using (FileStream soapFile = new FileStream(@"C:\Users\IET\source\repos\SerializaAssign\MyData2.soap", FileMode.Create))
            {
                sf.Serialize(soapFile, customer);
            }

            Console.WriteLine("Customer class serialized with SOAP using FileStream.");
        }
    }

    [Serializable]
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

