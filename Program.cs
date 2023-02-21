namespace merge_test;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Edward.");

		Console.WriteLine("Input address: ");
		var address = Console.ReadLine();
		Console.WriteLine($"Address: {address}");

		Console.Write("Input phone number: ");
		var phoneNumber = Console.ReadLine();
		Console.WriteLine($"Phone number: {phoneNumber}");

		Console.Write("Input gender: ");
		var gender = Console.ReadLine();
		Console.WriteLine($"Gender: {gender}");
	}
}
