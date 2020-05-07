using System;

namespace Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			PrinterWindows printer;
			Console.WriteLine("Choose a Printer: ");
			Console.WriteLine("1. Epson");
			Console.WriteLine("2. Canon");
			Console.WriteLine("3. LaserJet");
			
			Console.Write("Printer Number[1..3]: ");
			int printerNumber = Convert.ToInt32(Console.ReadLine());
			
			if (printerNumber == 1)
				printer = new Epson();
			else if (printerNumber == 2)
				printer = new Canon();
			else
				printer = new LaserJet();
			
			printer.Show();
			printer.Print();
			
			Console.ReadKey();
		}
	}
	
	public class PrinterWindows
	{
		public string printerName {get;set;}
		public string displayDimention {get;set;}
		
		public virtual void Show()
		{
			Console.WriteLine("Display dimension: ");
		}
		
		public virtual void Print()
		{
			Console.WriteLine("Printer printing....");
		}
	}
	
	public class Epson : PrinterWindows
	{
		public override void Show()
		
		{
			Console.WriteLine("Epson display dimension: 10*11");
		}
		
		public override void Print()
		{
			Console.WriteLine("Epson printer printing....");
		}
	}
	
	public class Canon : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("Canon display dimension: 9.5*12");
		}
		
		public override void Print()
		{
			Console.WriteLine("Canon printer printing....");
		}
	}
	
	public class LaserJet : PrinterWindows
	{
		public override void Show()
		{
			Console.WriteLine("LaserJet display dimension: 12*12");
		}
		
		public override void Print()
		{
			Console.WriteLine("LaserJet printer printing....");
		}
	}
}