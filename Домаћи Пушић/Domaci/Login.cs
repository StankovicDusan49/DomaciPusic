﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ednevnik2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_name.Text=="" || txt_pass.Text=="")
            {
                MessageBox.Show("Unesite E-Mail i Lozinku");
                return;
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM osoba WHERE email=@username", veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if (brojac==1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) ==0)
                        {
                            MessageBox.Show("Login Successful!");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            this.Hide();
                            Glavna2 frm_glavna = new Glavna2();
                            frm_glavna.Show();
                            /* Glavna frm_glavna = new Glavna();
                            frm_glavna.Show(); */
                        }
                        else
                        {
                            MessageBox.Show("Neispravna lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeci E-Mail");
                    }
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
