﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TGPSI18H_2218147_AfonsoSalvador_M16
{
    public partial class News : UserControl
    {
        public News()
        {
            InitializeComponent();
        }

        private string _nome;
        private string _descricao;
        private Image _image;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                titulopnl.Text = value;
            }
        }
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
               groupBox1.Text = value;
            }
        }
        public Image image
        {
            get
            {
                Byte[] byteBLOBData = new Byte[0];
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);

                pictureBox1.Image = System.Drawing.Image.FromStream(stmBLOBData);
                return _image;
            }
            set
            {
                _image = value;
                pictureBox1.Image = value;
            }
        }
        private void News_Load(object sender, EventArgs e)
        {

        }
    }
}
