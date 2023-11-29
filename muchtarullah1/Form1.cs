using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace muchtarullah1
{
    //tes git
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmanusia_Click(object sender, EventArgs e)
        {
            manusia mn1;
            mn1 = new manusia();

            mn1.nama = "muchtar";
            mn1.gender = 'L';
            mn1.tinggibadan = 160;

            textBox1.Text = "-";
            textBox2.Text = mn1.nama;
            textBox3.Text = "-";
            textBox4.Text = mn1.gender.ToString();
            textBox5.Text = mn1.tinggibadan.ToString();
        }

        private void btnpegawai_Click(object sender, EventArgs e)
        {
            pegawai pg1;
            pg1 = new pegawai();

            pg1.nip = "12345";
            pg1.nama = "muchtar";
            pg1.jabatan = "manager";
            pg1.gender = 'L';
            pg1.tinggibadan = 160;

            textBox1.Text = pg1.nip;
            textBox2.Text = pg1.nama;
            textBox3.Text = pg1.jabatan;
            textBox4.Text = pg1.gender.ToString();
            textBox5.Text = pg1.tinggibadan.ToString();
        }

        private void btnmahasiswa_Click(object sender, EventArgs e)
        {
            mahasiswa mhs1;
            mhs1 = new mahasiswa();

            mhs1.nim = "20222222";
            mhs1.nama = "muchtar";
            mhs1.jurusan = "Teknik Informatika";
            mhs1.gender = 'L';
            mhs1.tinggibadan = 160;

            textBox1.Text = mhs1.nim;
            textBox2.Text = mhs1.nama;
            textBox3.Text = mhs1.jurusan;
            textBox4.Text = mhs1.gender.ToString();
            textBox5.Text = mhs1.tinggibadan.ToString();

            label1.Text = "nim";
            label3.Text = "jurusan";

        }
    }
}
