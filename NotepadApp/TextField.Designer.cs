
namespace NotepadApp
{
	partial class TextField
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextField));
			this.addButton = new System.Windows.Forms.Button();
			this.textField_label = new System.Windows.Forms.RichTextBox();
			this.textField_close = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.textField_textbox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(203)))), ((int)(((byte)(251)))));
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addButton.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
			this.addButton.Location = new System.Drawing.Point(301, 621);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(103, 45);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// textField_label
			// 
			this.textField_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
			this.textField_label.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textField_label.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.textField_label.Location = new System.Drawing.Point(162, 91);
			this.textField_label.Name = "textField_label";
			this.textField_label.Size = new System.Drawing.Size(242, 33);
			this.textField_label.TabIndex = 4;
			this.textField_label.Text = "";
			// 
			// textField_close
			// 
			this.textField_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(203)))), ((int)(((byte)(251)))));
			this.textField_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.textField_close.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.textField_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
			this.textField_close.Location = new System.Drawing.Point(18, 621);
			this.textField_close.Name = "textField_close";
			this.textField_close.Size = new System.Drawing.Size(103, 45);
			this.textField_close.TabIndex = 5;
			this.textField_close.Text = "close";
			this.textField_close.UseVisualStyleBackColor = false;
			this.textField_close.Click += new System.EventHandler(this.textField_close_Click);
			// 
			// edit
			// 
			this.edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(203)))), ((int)(((byte)(251)))));
			this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.edit.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
			this.edit.Location = new System.Drawing.Point(301, 621);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(103, 45);
			this.edit.TabIndex = 6;
			this.edit.Text = "save";
			this.edit.UseVisualStyleBackColor = false;
			this.edit.Click += new System.EventHandler(this.edit_Click);
			// 
			// textField_textbox
			// 
			this.textField_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
			this.textField_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textField_textbox.Font = new System.Drawing.Font("Century Gothic", 15F);
			this.textField_textbox.Location = new System.Drawing.Point(18, 147);
			this.textField_textbox.Name = "textField_textbox";
			this.textField_textbox.Size = new System.Drawing.Size(386, 437);
			this.textField_textbox.TabIndex = 7;
			this.textField_textbox.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.label1.Location = new System.Drawing.Point(12, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 33);
			this.label1.TabIndex = 8;
			this.label1.Text = "Title";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(203)))), ((int)(((byte)(251)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 55);
			this.panel1.TabIndex = 9;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 20F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 33);
			this.label2.TabIndex = 0;
			this.label2.Text = "NotepadApp";
			// 
			// TextField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
			this.ClientSize = new System.Drawing.Size(416, 678);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textField_textbox);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.textField_close);
			this.Controls.Add(this.textField_label);
			this.Controls.Add(this.addButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TextField";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TextField";
			this.Load += new System.EventHandler(this.TextField_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.RichTextBox textField_label;
		private System.Windows.Forms.Button textField_close;
		private System.Windows.Forms.Button edit;
		private System.Windows.Forms.RichTextBox textField_textbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
	}
}