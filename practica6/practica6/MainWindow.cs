using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{

		this.p1.Text=" ";
			this.p2.Text=" ";
				this.p3.Text=" ";

		this.subtotal1.Text=" ";
		this.iva1.Text=" ";
		this.total1.Text=" ";

	}

	protected void OnFacturaClicked (object sender, EventArgs e)
	{
		double p1= double.Parse(this.p1.Text);
		double p2= double.Parse(this.p2.Text);
		double p3= double.Parse(this.p3.Text);
		double subtotal =p1+p2+p3;
		double iva=subtotal*0.16;
		double total=subtotal*iva;

		this.subtotal1.Text=subtotal.ToString();
		this.iva1.Text=iva.ToString();
		this.total1.Text=total.ToString();


	}
}
