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
			//TODO
		}
		else if (ans == "10")
		{
			dectobin();
		}
		else if (ans == "16")
		{ 
			//TODO
		}
		else
		{
            throw new ArgumentNullException("\e[91mERROR: \e[0mANSWER INVALID");
        }
	}
}