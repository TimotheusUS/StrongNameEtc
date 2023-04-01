using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	sealed class DerivedClass2 : BaseClass
	{
		public DerivedClass2() : base() { }
		public DerivedClass2(int x, int y) : base(x, y) { }

		public override void SayHello()
		{
			Console.WriteLine("Hello DerivedClass2");
		}
	}
}
