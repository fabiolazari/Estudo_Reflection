using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Estudo_Reflection
{
	class Program
	{
		static void Main(string[] args)
		{
			var objetoA = new A
			{
				Id = 100,
				Descricao = "Valor descricao"
			};

			var objetoB = new B();

			var propriedadesA = objetoA.GetType()
									   .GetProperties();

			foreach (var propA in propriedadesA)
			{
				var propertyInfoB = objetoB.GetType()
										   .GetProperty(propA.Name);
				if (propertyInfoB != null)
				{
					propertyInfoB.SetValue(objetoB, propA.GetValue(objetoA));
				}
			}

			Console.WriteLine(" Objeto A: " + objetoA.Id + " - " + objetoA.Descricao);
			Console.WriteLine(" Objeto B: " + objetoA.Id + " - " + objetoA.Descricao);

			Console.ReadKey();

		}

		class A
		{
			public int Id { get; set; }
			public string Descricao { get; set; }
		}

		class B
		{
			public int Id { get; set; }
			public string Descricao { get; set; }
		}
	}
}
