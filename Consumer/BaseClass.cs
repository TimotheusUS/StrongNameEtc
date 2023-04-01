using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
	class BaseClass
	{
		public int X { get; }

		public int Y { get; }

		private readonly int a;
		private const int b = 1;

		public int Number { get; }

		public BaseClass() {
			a = 5;
		}

		public BaseClass(int x, int y) => (X, Y) = (x, y);

		public virtual void SayHello()
		{
			new KeyOwner1.Class1().DoSomething();
		}
	}
}
