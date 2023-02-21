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
	public partial class notepad_item : UserControl
	{
		
		public notepad_item()
		{
			InitializeComponent();
		}

		public notepad_item(string Text)
		{
			InitializeComponent();
			lbl_item.Text = Text; // labels in items
		}

		public event EventHandler showTextField = null;
		public string value = null;

		// delete info from database
		private void del_button_Click(object sender, EventArgs e)
		{
			string id = Info.GetId(lbl_item.Text).ToString();
			Info.DeleteTextInBd(id);
			this.BackColor = Color.Tomato;
			lbl_item.Text = "deleted";
			del_button.Hide();
			edit_button.Hide();
		}

		private void lbl_item_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Click");
		}

		// if edit button pressed, get label id for show text in text field form, and show this form
		private void edit_button_Click(object sender, EventArgs e)
		{
			MainForm._edit = true;
			MainForm.id_label = Info.GetId(lbl_item.Text).ToString();			
			if (showTextField != null)
			{
				showTextField.Invoke(this, new EventArgs());
			}
		}

		private void notepad_item_Load(object sender, EventArgs e){}
	}
}
