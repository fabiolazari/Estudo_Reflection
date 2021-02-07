using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//Type t = Type.GetType("System.Console");
				//Type t = Type.GetType("System.Math");
				Type t = Type.GetType("System.Collections.ArrayList");

				//Metodos de busca
				CaracteristicasTipo(t);
				EncontraCampos(t);
				EncontraPropriedades(t);
				EncontraMetodos(t);
				EncontraInterfaces(t);

				Console.ReadKey();
			}
			catch (Exception)
			{
				Console.WriteLine("Verificar o Tipo!");
			}

		}

		public static void CaracteristicasTipo(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("As Caracteristicas são: ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Classe base  : {0}", t.BaseType);
			Console.WriteLine("É uma classe : {0}", t.IsClass);
			Console.WriteLine("É Abstrata   : {0}", t.IsAbstract);
			Console.WriteLine("É Seleda     : {0}", t.IsSealed);
			Console.WriteLine("É genérica   : {0}", t.IsGenericTypeDefinition);
			Console.WriteLine();
		}

		public static void EncontraCampos(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Os campos encontrados são: ");
			Console.ForegroundColor = ConsoleColor.White;

			var nomes = from f in t.GetFields() select f.Name;
			foreach (var nome in nomes)
			{
				Console.WriteLine("{0}", nome);
			}
			Console.WriteLine();
		}

		public static void EncontraPropriedades(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("As propriedades encontradas são: ");
			Console.ForegroundColor = ConsoleColor.White;

			var nomes = from p in t.GetProperties() select p.Name;
			foreach (var nome in nomes)
			{
				Console.WriteLine("{0}", nome);
			}
			Console.WriteLine();
		}

		public static void EncontraMetodos(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Os metodos encontrados são: ");
			Console.ForegroundColor = ConsoleColor.White;

			var nomes = from p in t.GetMethods() select p.Name;
			foreach (var nome in nomes)
			{
				Console.WriteLine("{0}", nome);
			}
			Console.WriteLine();
		}

		public static void EncontraInterfaces(Type t)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("As interfaces encontradas são: ");
			Console.ForegroundColor = ConsoleColor.White;

			var nomes = from i in t.GetInterfaces() select i;
			foreach (var nome in nomes)
			{
				Console.WriteLine("{0}", nome);
			}
			Console.WriteLine();
		}
	}

}
