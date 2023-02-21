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
	public partial class MainForm : Form
	{
		public static List<string> textList = new List<string>(); //list of notepad items
		public static string id_label; // get id labels from database
		public static bool _edit; // show or hide edit mode buttons and insert text
		public static int poss; //start position
		public static string label_txtfield; // get label from database
		public static string text_txtfield; //get text from database
		public MainForm()
		{
			InitializeComponent();
			panel1.MouseDown += panel1_MouseDown; // drag and drop for panel 1
			DisplayAll(); // display all notepad items
		}		

		// add notepad items
		public void addItem(string Text)
		{
			notepad_item item = new notepad_item(Text);
			panel2.Controls.Add(item);			
			item.showTextField += OpenTextField;
			item.Top = poss;
			poss = (item.Top + item.Height + 10);
		}

		// get all items from the list, refresh and display
		public void DisplayAll()
		{
			Info.GetAllStrings();
			panel2.Controls.Clear();
			poss = 10;
			foreach (var _list in textList)
			{
				addItem(_list);
			}
			
		}

		// show Text Field Form, but close Main Form
		private void button1_Click(object sender, EventArgs e)
		{
			_edit = false;
			OpenTextField(sender, e);
		}

		public void OpenTextField(object sender, EventArgs e)
		{
			TextField _addText = new TextField(this);
			_addText.ShowDialog();
			this.Hide();
			DisplayAll();
			this.Show();
		}
		// Close Button
		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
		// drag and drop for panel 1
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			panel1.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void MainForm_Load(object sender, EventArgs e){}

	}
}
