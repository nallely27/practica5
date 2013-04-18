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

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
	
		int numero1 = int.Parse(this.numero1.Text);
		int numero2 = int.Parse (this.numero2.Text);
		int res = numero1 + numero2;
		this.resultado.Text = res.ToString ();
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		int numero1 = int.Parse(this.numero1.Text);
		int numero2 = int.Parse (this.numero2.Text);
		int res = numero1 - numero2;
		this.resultado.Text = res.ToString ();
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		int numero1 = int.Parse(this.numero1.Text);
		int numero2 = int.Parse (this.numero2.Text);
		int res = numero1 * numero2;
		this.resultado.Text = res.ToString ();
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		int numero1 = int.Parse(this.numero1.Text);
		int numero2 = int.Parse (this.numero2.Text);
		int res = numero1 / numero2;
		this.resultado.Text = res.ToString ();
	}
}
