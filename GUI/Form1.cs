using BL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WorkerDTO worker = new WorkerDTO();
                worker = WorkerBl.GetWorker("rivka", "123");
                if (worker != null)
                    MessageBox.Show(worker.FirstName + " " + worker.Mail);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = BL.WorkerBl.GetWorkers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DomainBL.GetDomains();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (db_joBestEntities db = new db_joBestEntities())
                {
                    db.DomainsToWorker.Add(new DomainsToWorker() { IdDomain = 1021, Experience = "ddwd", IdWorker = 1 });
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
