using System;
using System.IO;
using Newtonsoft.Json;

namespace MeteMeTo
{
	public class Writer
	{
		public Writer(){
			
		}
		public void insertarSesion (long start, long duration, int distance)
		{  
			System.Console.WriteLine (start);
			System.Console.WriteLine (duration);
			System.Console.WriteLine (distance);

			Session session = new Session(start,duration,distance);

			string output = JsonConvert.SerializeObject(session);
			System.Console.WriteLine (output);

			File.WriteAllText ("./data.json", output);
		}

	}
}

