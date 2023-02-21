
namespace NotepadApp
{
	partial class notepad_item
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad_item));
			this.lbl_item = new System.Windows.Forms.Label();
			this.del_button = new System.Windows.Forms.Button();
			this.edit_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_item
			// 
			this.lbl_item.AutoSize = true;
			this.lbl_item.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_item.Font = new System.Drawing.Font("Century Gothic", 13F);
			this.lbl_item.Location = new System.Drawing.Point(34, 13);
			this.lbl_item.Name = "lbl_item";
			this.lbl_item.Size = new System.Drawing.Size(132, 21);
			this.lbl_item.TabIndex = 0;
			this.lbl_item.Text = "notepad item";
			this.lbl_item.Click += new System.EventHandler(this.lbl_item_Click);
			// 
			// del_button
			// 
			this.del_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("del_button.BackgroundImage")));
			this.del_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.del_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.del_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
			this.del_button.Location = new System.Drawing.Point(339, 13);
			this.del_button.Name = "del_button";
			this.del_button.Size = new System.Drawing.Size(24, 22);
			this.del_button.TabIndex = 1;
			this.del_button.UseVisualStyleBackColor = true;
			this.del_button.Click += new System.EventHandler(this.del_button_Click);
			// 
			// edit_button
			// 
			this.edit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit_button.BackgroundImage")));
			this.edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.edit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
			this.edit_button.Location = new System.Drawing.Point(298, 12);
			this.edit_button.Name = "edit_button";
			this.edit_button.Size = new System.Drawing.Size(24, 23);
			this.edit_button.TabIndex = 3;
			this.edit_button.UseVisualStyleBackColor = true;
			this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
			// 
			// notepad_item
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
			this.Controls.Add(this.edit_button);
			this.Controls.Add(this.del_button);
			this.Controls.Add(this.lbl_item);
			this.Name = "notepad_item";
			this.Size = new System.Drawing.Size(375, 49);
			this.Load += new System.EventHandler(this.notepad_item_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Button del_button;
		private System.Windows.Forms.Button edit_button;
	}
}
