using System;
using System.Text;
using ClassExploration;

namespace TestRunner
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("The parameterized constructor will write the passed values to the console when called.");
			
			Console.WriteLine("var class0 = new ClassToBeInitialized();");
			var class0 = new ClassToBeInitialized();
			Console.WriteLine(class0.ToString());
			Console.WriteLine();

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("var class1 = new ClassToBeInitialized()");
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("	FirstInt = 1,");
			stringBuilder.AppendLine("	SecondInt = 2,");
			stringBuilder.AppendLine("	AString = 'A',");
			stringBuilder.AppendLine("	BString = 'B'");
			stringBuilder.AppendLine("}; ");
			Console.WriteLine(stringBuilder.ToString());
			stringBuilder.Clear();
			var class1 = new ClassToBeInitialized()
			{
				FirstInt = 1,
				SecondInt = 2,
				AString = "A",
				BString = "B"
			};
			Console.WriteLine(class1.ToString());
			Console.WriteLine();

			stringBuilder.AppendLine("var class2 = new ClassToBeInitialized(10, 'a')");
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("	SecondInt = 20,");
			stringBuilder.AppendLine("	BString = 'b'");
			stringBuilder.AppendLine("};");
			Console.WriteLine(stringBuilder.ToString());
			stringBuilder.Clear();
			var class2 = new ClassToBeInitialized(10, "a")
			{
				SecondInt = 20,
				BString = "b"
			};
			Console.WriteLine(class2.ToString());
			Console.WriteLine();

			stringBuilder.AppendLine("var class3 = new ClassToBeInitialized(a: 'A0', first: 100)");
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("	SecondInt = 200,");
			stringBuilder.AppendLine("	BString = 'B0'");
			stringBuilder.AppendLine("};");
			Console.WriteLine(stringBuilder.ToString());
			stringBuilder.Clear();
			var class3 = new ClassToBeInitialized(a: "A0", first: 100)
			{
				SecondInt = 200,
				BString = "B0"
			};
			Console.WriteLine(class3.ToString());
			Console.WriteLine();

			stringBuilder.AppendLine("var class4 = new ClassToBeInitialized(a: 'A0', first: 100)");
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine("	FirstInt = 1000,");
			stringBuilder.AppendLine("	SecondInt = 2000,");
			stringBuilder.AppendLine("	AString = 'A1',");
			stringBuilder.AppendLine("	BString = 'B2'");
			stringBuilder.AppendLine("};");
			Console.WriteLine(stringBuilder.ToString());
			stringBuilder.Clear();
			var class4 = new ClassToBeInitialized(a: "A0", first: 100)
			{
				FirstInt = 1000,
				SecondInt = 2000,
				AString = "A1",
				BString = "B2"
			};
			Console.WriteLine(class4.ToString());
			Console.WriteLine();
		}
	}
}
