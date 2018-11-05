using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPublishTemplate
{
    public class Greeter
    {
		private string Name { get; set; }

		public Greeter(string name)
		{
			Name = name;
		}

		public void Hello()
		{
			Console.WriteLine("Hello " + Name);
		}
    }
}
