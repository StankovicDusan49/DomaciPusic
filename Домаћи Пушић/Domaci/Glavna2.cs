﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik2
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }

        private void oceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ocena frm_ocena = new Ocena();
            frm_ocena.Show();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Smer");
            frm_smer.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Skolska_godina");
            frm_smer.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Predmet");
            frm_smer.Show();
        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upisnica frm_upisnica = new upisnica();
            frm_upisnica.Show();
        }

        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
