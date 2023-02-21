using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadApp
{
	public partial class TextField : Form
	{
		private readonly MainForm _parent;
		public TextField(MainForm parent)
		{
			InitializeComponent();
			panel1.MouseDown += panel1_MouseDown;  // drag and drop for panel 1
			_parent = parent;
			
			// if edit mode = true, show label and text to user
			if (MainForm._edit == true)
			{
				addButton.Hide();
				edit.Show();
				Info.GetTxtById(MainForm.id_label);
				textField_label.Text = MainForm.label_txtfield;
				textField_textbox.Text = MainForm.text_txtfield;
			}
			if(MainForm._edit == false)
			{	
				// buttons
				edit.Hide();
				addButton.Show();
			}
			
		}
		// clear label and text fields
		public void Clear()
		{
			textField_label.Text = string.Empty;
			textField_textbox.Text = string.Empty;
		}

		public void addButton_Click(object sender, EventArgs e)
		{	
			// if label is empty show the message
			if (textField_label.Text.Trim().Length == 0)
			{
				MessageBox.Show("Empty");
				return;
			}
			// else add information to database
			TextInformation txtinf = new TextInformation(textField_label.Text.Trim(), textField_textbox.Text.Trim());
			Info.AddTextInBd(txtinf);
			Clear();
			_parent.DisplayAll();
			Close();
		}

		private void textField_close_Click(object sender, EventArgs e)
		{
			Clear();
			Close();
		}

		private void edit_Click(object sender, EventArgs e)
		{
			// if label is empty show the message
			if (textField_label.Text.Trim().Length == 0)
			{
				MessageBox.Show("Empty");
				return;
			}
			// else update information in database
			TextInformation txtinf = new TextInformation(textField_label.Text.Trim(), textField_textbox.Text.Trim());
			Info.UpdateTextInBd(txtinf, MainForm.id_label);
			Clear();
			Close();
		}

		private void TextField_Load(object sender, EventArgs e){}
		private void label1_Click(object sender, EventArgs e){}
		private void panel1_Paint(object sender, PaintEventArgs e){}


		// drag and drop for panel 1
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}
	}
}
