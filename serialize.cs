using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace OOps Learning
{
	public Class1()
	{
		static void XMLSerialize() { 
			person person= new Person { name="kitty", Age=03  };
			xmlSerializer serialize = new xmlSerializer(typeof(Person));
			using (FileStream stream = new FileStream("details.xml",FileMode.Create))
			{
				serialize.Serialize(stream, person);
			}
		}
    static void XMLDeSerialize()
    {
        using (FileStream stream = new FileStream("details.xml", FileMode.Open))
        {
            serialize.Serialize(stream, person);
        }
    }
}
	static void Main(string[] args)
		{
	Console.WriteLine("Hello World");

}
}
