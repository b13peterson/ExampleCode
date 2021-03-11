using System;

namespace ClassExploration
{
	public class ClassToBeInitialized
	{
		public int FirstInt { get; set; }
		public int SecondInt;
		private int thirdInt;
		public string AString { get; set; }
		public string BString;
		private string cString;

		public ClassToBeInitialized() {	}

		public ClassToBeInitialized(int first, string a) {
			FirstInt = first;
			AString = a;
			Console.WriteLine($"Set FirstInt to {FirstInt} and AString to {AString} by constructor");
		}

		public override string ToString() => $"FirstInt={FirstInt} SecondInt={SecondInt} thirdInt={thirdInt} AString={AString} BString={BString} cString={cString}";
	}
}
