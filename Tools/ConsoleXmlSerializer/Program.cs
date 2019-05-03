namespace ConsoleXmlSerializer
{
    using System;
    using Models;
    using XmlSerializer;

    class Program
    {
        static void Main(string[] args)
        {
            var classTest = new ClassTest
            {
                MyProperty = 1,
                TextFiled = "Text Here!",
                NoMapped = true,
                Array = new ArrayClass(),
                Array2 = new ArrayClass2[] { new ArrayClass2 { Id = 1, Value = "Value 1" }, new ArrayClass2 { Id = 2, Value = "Value 2" } },
                Array3 = new ArrayClass3[] { new ArrayClass3 { Id = 1, Value = "Value 1" }, new ArrayClass3 { Id = 2, Value = "Value 2" } }
            };

            classTest.Array.Array1 = new ArrayClass1[] { new ArrayClass1 { Id = 1, Value = "Value 1" }, new ArrayClass1 { Id = 2, Value = "Value 2" } };

            string xml = Serializer.Serialize(classTest);
            Console.WriteLine(xml);

            var deserializeClass = Serializer.Deserialize<ClassTest>(xml);
            Console.WriteLine(deserializeClass);

            Console.Read();
        }
    }
}
