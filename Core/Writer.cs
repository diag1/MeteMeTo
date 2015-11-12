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
			Session session = new Session(start,duration,distance);

			using (StreamWriter file = File.CreateText("./data.json"))
			{
				JsonSerializer serializer = new JsonSerializer();
				serializer.Serialize(file, session);
			}
		}

	}
}

