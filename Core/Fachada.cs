using System;

namespace MeteMeTo
{
	public interface Fachada
	{
		 double average (int distance, int time);
		 void setSession(DateTime start, DateTime duration, int distance);

	}
}

