using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Test_Task2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("Task2")]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(1, 3, 273.7)]
        [DataRow(10, 3, 2499)]
        [DataRow(1, 2, 190.4)]

        public void Test_InOut(double value_1, double value_2, double value_3)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var textReader = new StringReader(@$"{value_1}
{value_2}");

            Console.SetIn(textReader);

            // Act
            Aufgabe_4.Aufgabe4();

            // Assert

            var sb = writer.GetStringBuilder();
            var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.None);

            List<string> lines_list = new List<string>();

            //Bedingung nötig da 'Enviroment.NewLine' in Git Actions nicht funktioniert.
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lines_list.Add(lines[i]);
                    Debug.WriteLine($"{lines[i]}");
                }
            }

            List<string> lines_list_check = new List<string> { $"Der Gesamtpreis beträgt:{value_3,10:F2}{" EUR"}" };


            lines_list = lines_list.Intersect(lines_list_check).ToList();


            for (int i = 0; i < lines_list_check.Count; i++)
            {

                try
                {
                    if (lines_list[i] != lines_list_check[i]) Trace.WriteLine($"\nFehler: '{lines_list_check[i]}' nicht gefunden");
                    Assert.AreEqual(lines_list[i], lines_list_check[i]);
                }
                catch
                {
                    Trace.WriteLine($"Fehler: Zeilen fehlen");
                    Assert.Fail(); ;

                }

            }

        }
    }
}

