using System;
using System.Data.SqlTypes;

internal class Program
{
	public static void prompt()
	{
		Console.Write($"\e[92m{{{Environment.UserName}@{Environment.MachineName}}}% \e[0m");
	}
	public static void dectobin()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		int num = Convert.ToInt32(Console.ReadLine());
		Console.Write($"\e[?1049l\e[H{Convert.ToString(num, 2)}");
	}
	public static void bintodec()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		var num = Console.ReadLine();
		Console.Write($"\e[?1049l\e[H{Convert.ToInt32(num, 2).ToString()}");
	}
	public static void bintohex()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		var num = Console.ReadLine();
		Console.WriteLine($"\e[?1049l\e[H{Convert.ToInt32(num, 2).ToString("X")}");
	}
	public static void dectohex()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"\e?1049l\e[H{num.ToString("X")}");
	}
	public static void hextobin()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		var num = Console.ReadLine();
		Console.WriteLine($"\e?1049l\e[H{Convert.ToInt32(num, 2)}");
	}
	public static void hextodec()
	{
		Console.Write($"\e[2J\e[Henter a number :3\n");
		prompt();
		var num = Console.ReadLine();
		Console.WriteLine($"\e?1049l\e[H{Convert.ToInt32(num, 16)}");
	}
	public static void Main()
	{
		Console.WriteLine("\e[H\e[?1049hwhat base d'you wanna start with ? 2, 10 or 16 ?");
		prompt();
		var ans = Console.ReadLine();
		if (ans == "2")
		{
			Console.WriteLine("to dec or hex ?");
			prompt();
			ans = Console.ReadLine();
			if (ans == "dec") bintodec();
			else if (ans == "hex") bintohex();
			else throw new ArgumentNullException("\e[91mERROR: \e[0mANSWER INVALID");
		}
		else if (ans == "10")
		{
			Console.WriteLine("to bin or hex ?");
			prompt();
			ans = Console.ReadLine();
			if (ans == "bin") dectobin();
			else if (ans == "hex") dectohex();
			else throw new ArgumentNullException("\e[91mERROR: \e[0mANSWER INVALID");
		}
		else if (ans == "16")
		{
			Console.WriteLine("to bin or dec ?");
			prompt();
			ans = Console.ReadLine();
			if (ans == "bin") hextobin();
			else if (ans == "dec") hextodec();
			else throw new ArgumentNullException("\e[91mERROR: \e[0mANSWER INVALID");
		}
		else
		{
			throw new ArgumentNullException("\e[91mERROR: \e[0mANSWER INVALID");
		}
	}
}