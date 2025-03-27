using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaTest;

using Xsd2.Capitalizers;

namespace Xsd2.Tests
{
    [TestFixture]
    public class GenerationTests
    {
        [Test]
        public void Test1()
        {
            var options = new XsdCodeGeneratorOptions
            {
                Imports = new List<string>() { @"Schemas\MetaConfig.xsd" },
                PropertyNameCapitalizer = new FirstCharacterCapitalizer(),
                OutputNamespace = "XSD2",
                UseLists = true,
                UseNullableTypes = true,
                ExcludeImportedTypes = true,
                AttributesToRemove =
                {
                    "System.Diagnostics.DebuggerStepThroughAttribute"
                }
            };

            using (var o = File.CreateText(@"Schemas\Xsd2Config.cs"))
            {
                var generator = new XsdCodeGenerator() { Options = options };
                generator.Generate(new[] { @"Schemas\Xsd2Config.xsd" }, o);
            }
        }

        [Test(Active = true)]
        public void Filling()
        {
            string basePath = @"C:\Users\Lenovo\Downloads\xsd2\Xsd2.Tests\Schemas\";
            var options = new XsdCodeGeneratorOptions
            {
                Imports = new List<string>() { },
                PropertyNameCapitalizer = new FirstCharacterCapitalizer(),
                OutputNamespace = "XSD2",
                UseLists = true,
                UseNullableTypes = true,
                ExcludeImportedTypes = true,
                AttributesToRemove =
                {
                    "System.Diagnostics.DebuggerStepThroughAttribute"
                }
            };

            using (var o = File.CreateText(basePath + @"Crs.cs"))
            {
                List<string> listSchema = new List<string>();
                var generator = new XsdCodeGenerator() { Options = options };
                //foreach (var file in Directory.GetFiles(basePath + @"filling", "*.xsd"))
                //{
                //    if (!file.Contains("T619_PartXIX.xsd"))
                //    {
                //        listSchema.Add(file);
                //    }
                //}


                generator.Generate(
new[] {
    basePath+@"filling\T619_PartXIX.xsd",
    basePath+@"filling\complex.xsd",
                basePath+@"filling\simple.xsd",
                basePath+@"filling\agr-1.xsd",
                    basePath+@"filling\t4fhsa.xsd",
                basePath+@"filling\lemmcommontypes.xsd",
                basePath+@"filling\standarddatatypes.xsd",
                basePath+@"filling\cracommonstructures.xsd",
                basePath+@"filling\t2202.xsd",
                basePath+@"filling\partxix.xsd",
                basePath+@"filling\partxviii.xsd",
                basePath+@"filling\rrsp-rrif-nqi.xsd",
                basePath+@"filling\prpp.xsd",
                basePath+@"filling\t5018.xsd",
                basePath+@"filling\t4e.xsd",
                basePath+@"filling\safer.xsd",
                basePath+@"filling\nr4.xsd",
                basePath+@"filling\t3.xsd",
                basePath+@"filling\t5007.xsd",
                basePath+@"filling\tfsa.xsd",
                 basePath+@"filling\t5008.xsd",
                 basePath+@"filling\t5.xsd",
                 basePath+@"filling\t1204.xsd",
                 basePath+@"filling\t4a-p.xsd",
                 basePath+@"filling\t4a-oas.xsd",
                  basePath+@"filling\rrsp.xsd",
                   basePath+@"filling\t215.xsd",
                basePath+@"filling\t4rsp.xsd",
                basePath+@"filling\t4rif.xsd",
                basePath+@"filling\t4a-nr.xsd",
                basePath+@"filling\t4a.xsd",
                 basePath+@"filling\t4.xsd",
                // basePath+@"filling\t4a-p.xsd",
                // basePath+@"filling\t4a-oas.xsd",
                }


            , o);
            }
        }

        [Test(Active = false)]
        public void Test2()
        {
            var options = new XsdCodeGeneratorOptions
            {
                PropertyNameCapitalizer = new FirstCharacterCapitalizer(),
                OutputNamespace = "XSD2",
                UseLists = true,
                UseNullableTypes = true,
                ExcludeImportedTypes = true,
                AttributesToRemove =
                {
                    "System.Diagnostics.DebuggerStepThroughAttribute"
                }
            };

            using (var o = File.CreateText(@"Schemas\Data.cs"))
            {
                var generator = new XsdCodeGenerator() { Options = options };
                generator.Generate(new[] { @"Schemas\Data.xsd" }, o);
            }
        }

        [Test(Active = false)]
        public void Test3()
        {
            var options = new XsdCodeGeneratorOptions
            {
                PropertyNameCapitalizer = new FirstCharacterCapitalizer(),
                OutputNamespace = "XSD2",
                UseLists = true,
                UseNullableTypes = true,
                ExcludeImportedTypes = true,
                MixedContent = true,
                AttributesToRemove =
                {
                    "System.Diagnostics.DebuggerStepThroughAttribute"
                }
            };

            using (var o = File.CreateText(@"Schemas\Form.cs"))
            {
                var generator = new XsdCodeGenerator() { Options = options };
                generator.Generate(new[] { @"Schemas\Form.xsd" }, o);
            }
        }

    }
}
