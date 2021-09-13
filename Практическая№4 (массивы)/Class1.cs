using System;

class HelloWorld
{
	static void Maрррin()
	{
		int m, n, p, q;
		int a, b, c;
		m = Int32.Parse(Console.ReadLine());
		n = Int32.Parse(Console.ReadLine());
		p = Int32.Parse(Console.ReadLine());
		q = Int32.Parse(Console.ReadLine());


		a = n * q;
		b = -(m * q + n * p);
		c = m * p;


		Console.Write(a + " "  + b + " " + c);
	}
}

