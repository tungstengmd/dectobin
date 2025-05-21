Console.Write($"enter a number :3\n\e[92m{{{Environment.UserName}@{Environment.MachineName}}}% \e[0m");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(Convert.ToString(num, 2));