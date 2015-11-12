using System;
using Gtk;

namespace MeteMeTo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			var wMain = new MainWindow ();
			wMain.Show ();
			Application.Run ();
		}
	}
}
