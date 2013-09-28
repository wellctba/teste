using System;

namespace mx5server
{
	class MainClass
	{
		int teste;
		public static void Main (string[] args)
		{
			Console.WriteLine ("Maximus Server - v5.0");
			Console.WriteLine ("By Eduardo Fonseca <ebf@aedsol.com>\n");

			Servidor	srv = new Servidor(8899); // inicializa um objeto servidor passando como parâmetro a porta 8899
			srv.inicializaServidor();
			// executa o método inicializaServidor() do objeto srv

		}
	}
}
