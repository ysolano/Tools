namespace ConsoleXmlSerializer.Models
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlRoot("class_test")]
    public class ClassTest
    {
        public int MyProperty { get; set; }

        [XmlElement("text_field")]
        public string TextFiled { get; set; }

        [XmlIgnore]
        public bool NoMapped { get; set; }

        [XmlElement("array")]
        public ArrayClass Array { get; set; }

        public ArrayClass2[] Array2 { get; set; }

        [XmlElement("array_3")]
        public ArrayClass3[] Array3 { get; set; }

        public override string ToString()
        {
            return "MyProperty: " + MyProperty + ", TextField: " + TextFiled + ", boolValue: " + NoMapped.ToString();
        }
    }

    [Serializable]
    public partial class ArrayClass
    {
        [XmlElement("array_1")]
        public ArrayClass1[] Array1 { get; set; }
    }

    [Serializable]
    public partial class ArrayClass1
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }

    [Serializable]
    public class ArrayClass2
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }

    [Serializable]
    public class ArrayClass3
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
