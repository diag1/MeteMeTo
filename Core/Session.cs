using System;

namespace MeteMeTo
{
	public class Session
	{
		private long start{ get; set;}
		private long duration{ get; set;}
		private int distance{ get; set;}
		private int weight{ get; set;}



		public Session(long sta, long dur,int dis,int wei)
		{
			start = sta;
			duration = dur;
			distance = dis;
			weight = wei;
		}

		public Session(long sta, long dur,int dis)
		{
			start = sta;
			duration = dur;
			distance = dis;
			weight = 0;
		}


	}
}

