using System;
using Gtk;

namespace MeteMeTo
{
	public partial class MainWindow: Gtk.Window
	{
			public MainWindow () 
					:base (Gtk.WindowType.Toplevel)
			{
				fa = new Functions ();
				this.build ();
				this.vBoxMain.Visible = false;
				porMain ();
			}

			private void build()
			{
				this.buildMain ();

				var a =  new Gtk.VBox (false, 5);

				this.vBoxMain.Visible = true;	
				a.PackStart (vBoxMain);

				this.Add (a);
				a.ShowAll ();
				//events
				this.DeleteEvent += (o, args) =>this.OnClose() ;
			}

			private void buildMain()
			{
				SetDefaultSize(250, 200);
				vBoxMain = new Gtk.VBox (false, 5);
				//widgets
				this.lb1 = new Gtk.Label("INTRODUZCA SUS DATOS");
				lb1.UseMarkup = true;
				this.lb2 = new Gtk.Label ("Dia de sesión (dd/mm/yyyy):");
				this.en1 = new Gtk.Entry();

		
				this.en1.Alignment = 1;
				this.lb3 = new Gtk.Label("Distancia (metros):");
				this.en2 = new Gtk.Entry("0");
				this.en2.Alignment = 1;

				this.lb5 = new Gtk.Label("Tiempo (minutos) :");
				this.en3 = new Gtk.Entry("0");

		
				this.en3.Alignment = 1;
				this.lb6 = new Gtk.Label("Velocidad Media :");
				this.lb7 = new Gtk.Label("");
				//this.lb7.SetAlignment ((1/2), 0);
				
				this.btSave = new Gtk.Button("Guardar");
				//vBox
				vBoxMain.PackStart(this.lb1,true,false,5);
					// session day
				vBoxMain.PackStart(this.lb2,true,false,5);
				vBoxMain.PackStart(this.en1,true,false,5);
					//Distance
				vBoxMain.PackStart(this.lb3,true,false,5);
				vBoxMain.PackStart(this.en2,true,false,5);
					//Time
				vBoxMain.PackStart(this.lb5,true,false,5);
				vBoxMain.PackStart(this.en3,true,false,5);	
				//Average
				vBoxMain.PackStart(this.lb6,true,false,5);
				vBoxMain.PackStart(this.lb7,true,false,5);
					// Save button
				vBoxMain.PackStart(this.btSave,true,false,5);


				//events
				this.DeleteEvent += (o, args) =>this.OnClose() ;
				this.btSave.Clicked += (o, args) => this.introduce ();
			}

			private void porMain()
			{
				vBoxMain.Visible = true;
			}

		private Gtk.Button btSave;

		private Functions fa;

		private Gtk.Entry en1;
		private Gtk.Entry en2;
		private Gtk.Entry en3;

		private Gtk.Label lb1;
		private Gtk.Label lb2;
		private Gtk.Label lb3;
		private Gtk.Label lb5;
		private Gtk.Label lb6;
		private Gtk.Label lb7;

		private Gtk.VBox vBoxMain;
	

	}
}
