using System;

namespace MeteMeTo
{
	public class Session
	{
		public long start{ get; set;}
		public long duration{ get; set;}
		public int distance{ get; set;}
		public int weight{ get; set;}



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

