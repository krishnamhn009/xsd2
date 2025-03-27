using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XSD2;

namespace Xsd2.Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            ReturnType returnType = new ReturnType()
            {
                T619 =new TransmitterType(),
                Return=new List<PartXIXReturnChoiceType>()
            
            };
            string basePath = @"C:\Users\Lenovo\Downloads\xsd2\Xsd2.Tests\Schemas\";
            // Serialize to XML and save to file
            SerializeToXml(returnType, basePath+@"\crs.xml");

            PetaTest.Runner.RunMain(args);
        }

        public static void SerializeToXml<T>(T obj, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
