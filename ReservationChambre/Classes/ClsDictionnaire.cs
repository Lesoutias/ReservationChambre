﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationChambre.Classes
{
    internal class ClsDictionnaire
    {
        public static ClsDictionnaire Instance = null;

        public static ClsDictionnaire GetInstance()
        {
            if (Instance == null)
                Instance = new ClsDictionnaire();
            return Instance;
        }

        SqlConnection connection = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;
        SqlDataReader reader = null;
        private SqlDataAdapter dt;
        private SqlDataReader dr;

        public void OpenConnection()
        {
            try 
            {  
                connection = new SqlConnection(ClsConnection.ConnectionString);
            }
            catch (Exception ex)
            {
                throw new Exception("Error opening connection: " + ex.Message);
            }
        }
        public void SaveClient(ClsClient client)
        {
            try
            {
                OpenConnection();
                connection.Open();
                command = new SqlCommand("Exec SaveClient @id,@noms,@adresse,@contact,@refCategorie", connection);
                command.Parameters.AddWithValue("@id", client.Id);
                command.Parameters.AddWithValue("@noms", client.Noms);
                command.Parameters.AddWithValue("@adresse", client.Adresse);
                command.Parameters.AddWithValue("@contact", client.Contact);
                command.Parameters.AddWithValue("@refCategorie", client.RefCategorie);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insertion Echoue");
            }
            
        }

        public void SaveCategorie(ClsCategorisation cat)
        {
            try
            {
                OpenConnection();
                connection.Open();
                command = new SqlCommand("Exec SaveCategorisation @id,@designationCategorisation", connection);
                command.Parameters.AddWithValue("@id", cat.Id);
                command.Parameters.AddWithValue("@designationCategorisation", cat.DesignationCat);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void deleteData(string nomtable, string champ_id, int id)
        {
            OpenConnection();
            connection.Open();
            command = new SqlCommand("DELETE FROM " + nomtable + " where " + champ_id + " = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public DataTable loadData(string nomTable)
        {

            OpenConnection();
            if (!connection.State.ToString().ToLower().Equals("open")) connection.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("select * from " + nomTable + "", connection);
            dt.Fill(table);
            connection.Close();

            return table;
        }

        public void loadCombo(string nomTable, string nomchamp, System.Windows.Forms.ComboBox comb1)
        {
            OpenConnection();
            if (!connection.State.ToString().ToLower().Equals("open")) connection.Open();
            DataTable table = new DataTable();
            dt = new SqlDataAdapter("SELECT " + nomchamp + " FROM " + nomTable + "", connection);
            try
            {
                DataTable dt1 = new DataTable();
                dt.Fill(dt1);

                foreach (DataRow dr in dt1.Rows)
                {
                    comb1.Items.Add(dr[nomchamp]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }

            connection.Close();
        }

        public string getcode_Combo(string nomTable, string nomChampId, string nomChamp, string valeur)
        {
            string IdData = "";
            try
            {
                OpenConnection();
                if (!connection.State.ToString().ToLower().Equals("open")) connection.Open();
                command = new SqlCommand("select " + nomChampId + " from " + nomTable + " where " + nomChamp + "=@a", connection);
                command.Parameters.AddWithValue("@a", valeur);
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    IdData = (dr[nomChampId].ToString());
                }
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return IdData;
        }
    }
}
