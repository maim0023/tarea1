using System;

namespace tarea
{


  class MainClass
	{
		public static void Main (string[] args)
		{
			Persona persona = new Persona ();
			Console.WriteLine ("Cual es  tu nombre: ");
			persona.nombre = Console.ReadLine ();

			Console.WriteLine ("Cual es tu telefono: ");
			persona.telefono = Console.ReadLine ();

			Console.WriteLine ("Cual es tu E-mail: ");
			persona.email = Console.ReadLine ();

			Console.WriteLine ("Cual es tu Domicilio: ");
			persona.domicilio = Console.ReadLine ();

			Console.WriteLine (":::Datos de Persona::: ");
			Console.WriteLine ("Nombre: " + persona.nombre);
			Console.WriteLine ("Domicilio: " + persona.domicilio);
			Console.WriteLine ("Telefono: " + persona.telefono);
			Console.WriteLine ("E-mail: " + persona.email);
			Console.ReadLine ();
		}
	}
}
