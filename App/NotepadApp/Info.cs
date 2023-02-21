using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadApp
{
	class Info
	{
		// connect to database
		public static MySqlConnection GetConnection()
		{
			string sql = "datasource=localhost;port=3306;username=root;password=;database=notepadapp";

			MySqlConnection con = new MySqlConnection(sql);

			try
			{
				con.Open();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("MySQL Connection \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return con;			
		}
		
		public static void AddTextInBd(TextInformation std)
		{
			string sql = "INSERT INTO text_information VALUES (NULL, NULL, @NotepadAppLabel, @NotepadAppLabel_Info)";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@NotepadAppLabel", MySqlDbType.Text).Value = std._Label;
			cmd.Parameters.Add("@NotepadAppLabel_Info", MySqlDbType.Text).Value = std._LabelInfo;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Added Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Text not insert. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
		}


		public static void UpdateTextInBd(TextInformation std, string id)
		{
			string sql = "UPDATE text_information SET Label = @NotepadAppLabel, Label_Info = @NotepadAppLabel_Info WHERE ID = @NotepadAppID";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@NotepadAppLabel", MySqlDbType.Text).Value = std._Label;
			cmd.Parameters.Add("@NotepadAppLabel_Info", MySqlDbType.Text).Value = std._LabelInfo;
			cmd.Parameters.Add("@NotepadAppID", MySqlDbType.Text).Value = id;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Update Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Text not update. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
		}

		public static void DeleteTextInBd(string id)
		{
			string sql = "DELETE FROM text_information WHERE ID = @NotepadAppID";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@NotepadAppID", MySqlDbType.Text).Value = id;

			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Text not delete. \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
		}

		public static int GetId(string label_item)
		{
			string sql = "SELECT ID FROM text_information WHERE Label = '" + label_item + "'";
			int id = 0;
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			MySqlDataReader sdr = cmd.ExecuteReader();
			while (sdr.Read())
			{
				id = (int)sdr.GetValue(0);
			}
			con.Close();
			return id;
		}

		public static void GetTxtById(string labelinfo)
		{
			string sql = "SELECT Label, Label_Info FROM text_information WHERE ID = " + labelinfo;
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			MySqlDataReader sdr = cmd.ExecuteReader();
			while (sdr.Read())
			{
				MainForm.label_txtfield = (string)sdr.GetValue(0);
				MainForm.text_txtfield = (string)sdr.GetValue(1);
			}
			con.Close();
		}

		public static void GetAllStrings()
		{
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand("SELECT Label FROM text_information", con);
			MySqlDataReader sdr = cmd.ExecuteReader();
			MainForm.textList.Clear();
			while (sdr.Read())
			{
				MainForm.textList.Add((string)sdr.GetValue(0));
			}

			con.Close();			
		}

	}
}
