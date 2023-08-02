using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClipboardCollector
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		string testo_old;
		string testo_new;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.Button button1;
        private CheckBox checkBox_copia;
		private System.ComponentModel.IContainer components;

		public Form1()
		{

			InitializeComponent();
			
			try
			{
				InizializzaSenzaIncollare();
			}
			catch(Exception) {testo_old="";}
			
			timer1.Start();
		}
		private void InizializzaSenzaIncollare()
		{
			IDataObject appunti = Clipboard.GetDataObject();
			if (appunti.GetDataPresent(DataFormats.Text)) 
				testo_old=appunti.GetData(DataFormats.Text).ToString();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_copia = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(504, 369);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(14, 404);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(269, 18);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Elimina spazi bianchi all\'inizio e alla fine";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(14, 422);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(269, 19);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Vai a capo ad ogni incollatura";
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(302, 404);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(221, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Aggiungi        ad ogni incollatura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(19, 22);
            this.textBox1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(5, 468);
            this.trackBar1.Maximum = 90;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 52);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trasparenza";
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(14, 496);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(183, 28);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Bianco 100% trasparente";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(302, 459);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(125, 28);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Always on top";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(302, 496);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(144, 28);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Nascondi l\'icona";
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Copia Tutto";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox_copia
            // 
            this.checkBox_copia.Checked = true;
            this.checkBox_copia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_copia.Location = new System.Drawing.Point(14, 378);
            this.checkBox_copia.Name = "checkBox_copia";
            this.checkBox_copia.Size = new System.Drawing.Size(269, 19);
            this.checkBox_copia.TabIndex = 2;
            this.checkBox_copia.Text = "Copia";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(504, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox_copia);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Name = "Form1";
            this.Text = "CopyAutoPaster";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			IDataObject appunti = Clipboard.GetDataObject();
			if (appunti.GetDataPresent(DataFormats.Text)) 
			{
				testo_new=appunti.GetData(DataFormats.Text).ToString();
				
				if(!testo_new.Equals(testo_old))
				{
					testo_old=testo_new;
					richTextBox1.Text+=Parse(testo_new);
				}
			}
					

		}

		private string Parse(string testo)
		{
			if(checkBox1.Checked) 
				testo=testo.Trim();
			if(checkBox3.Checked)
				testo+=textBox1.Text;
			if(checkBox2.Checked && !richTextBox1.Text.Equals("")) 
				testo="\n"+testo;
			return testo;
		}
		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			this.TopMost=checkBox5.Checked;
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			double trasparenza = ((double) 100-trackBar1.Value)/100;
			this.Opacity=trasparenza;
		}

		private void checkBox4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox4.Checked) this.TransparencyKey=Color.White;
			else this.TransparencyKey=Color.Empty;
		}

		private void checkBox6_CheckedChanged(object sender, System.EventArgs e)
		{
			this.ShowInTaskbar=!checkBox6.Checked;
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
            if (checkBox_copia.Checked)
            {
                richTextBox1.SelectAll();
                testo_old = richTextBox1.SelectedText;
                Clipboard.SetDataObject(testo_old, true);
            }
		}


	}
}
