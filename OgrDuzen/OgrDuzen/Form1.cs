using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OgrDuzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataReader dr2 = cmd2.ExecuteReader();
            dr2.Read();
        txtVeliCep .Text  = dr2["CepTel"].ToString();
       textBox2.Text    = dr2["Adi"].ToString();
          txtVeliSoyAdi.Text  = dr2["Soyadi"].ToString();
         txtVeliEvTel.Text  = dr2["EvTel"].ToString();
          txtVeliTc.Text = dr2["TcNo"].ToString();
         txtVeliYakinlikDerecesi .Text  = dr2["YakinlikDerecesi"].ToString();
         txtVeliMeslek.Text = dr2["Meslek"].ToString();
          txtVeliEmail .Text = dr2["Email"].ToString();
          dr2.Close();
          SqlDataReader dr3 = cmd3.ExecuteReader();
          dr3.Read();
        txtUcuncuSahisCep.Text= dr3["CepTel"].ToString();
       txtUcuncuSahisAd.Text     = dr3["Adi"].ToString();
        txtUcuncuSahisSoyad.Text    = dr3["Soyadi"].ToString();
        txtUcuncuSahisEvTel.Text    = dr3["EvTel"].ToString();
         txtUcuncuSahisTc.Text   = dr3["TcNo"].ToString();
         txtUcuncuSahisYakinlikDerecesi.Text   = dr3["YakinlikDerecesi"].ToString();
          txtUcuncuSahisMeslek.Text  = dr3["Meslek"].ToString();
           txtUcuncuSahisEmail.Text = dr3["Email"].ToString();
           dr3.Close();
           cnn.Close();
        }


        


    

     
    }
}
        }
    }
}
