using System;
using System.Windows.Forms;
using System.Drawing;


namespace Assignment2
{
	public class MainForm : Form
    {

        public MainForm() : base()
		{
			Text = "Assignment 2";
			Width = 800;
			Height = 600;
            BackColor = Color.Black;
			DoubleBuffered = true;
		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(662, 538);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }
    }
}
