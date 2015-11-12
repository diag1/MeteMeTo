using System;

namespace MeteMeTo
{
	public class Functions:Fachada
	{
		public Functions ()
		{
			wr = new Writer ();
		}

		public double average (int distance, int time)
		{
			return Convert.ToDouble(distance / time);
		}	

		public void setSession(DateTime start, DateTime duration, int distance)
		{
			long a=ToEpochTime (start);
			long b=ToEpochTime (duration);

			wr.insertarSesion (a,b,distance);
			//Comprobar campos , especialmente ; e :

		}
		private long ToEpochTime(DateTime date)
		{
			var epoch = new DateTime (1970,1,1,0,0,0,DateTimeKind.Utc);
			return Convert.ToInt64 ((date - epoch).TotalSeconds);
		}	

		private Writer wr;
	}
}

