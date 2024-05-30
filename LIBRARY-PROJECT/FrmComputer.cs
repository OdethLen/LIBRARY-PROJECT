using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.DataFormats;
using DocumentFormat.OpenXml.Wordprocessing;

namespace LIBRARY_PROJECT
{

    public partial class btnBack : Form
    {
        ArrayList computerregister = new ArrayList();
        public btnBack()
        {
            InitializeComponent();

        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Load(object sender, EventArgs e)
        {

        }


        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            try
            {
                Computer computer = new Computer(Convert.ToString(txtNamec.Text), Convert.ToDateTime(dtpcomputer.Text), Convert.ToString(txtComputernum.Text), Convert.ToInt16(txtNoprints.Text));
                computer.Name = txtNamec.Text;
                computer.Date = Convert.ToDateTime(dtpcomputer.Text);
                computer.Computernumber = txtComputernum.Text;
                computer.Print_number = Convert.ToInt16(txtNoprints.Text);
                computer.Total = Math.Round(computer.Gettotal(computer.Cost, computer.Print_number), 2);
                computerregister.Add(computer);
                lblprinttotal.Text = "Total: " + computer.Total.ToString();
                dgvComputer.DataSource = null;
                dgvComputer.DataSource = computerregister;

            }
            catch (Exception)
            {
                MessageBox.Show("Exception ");
                return;
            }


        }

        private void btnNewcomputer_Click(object sender, EventArgs e)
        {
            txtNamec.Clear();
            txtComputernum.Clear();
            txtNoprints.Clear();
            dtpcomputer.Value = DateTime.Now;
        }

        private void btnExporttxtc_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files |*.txt";
            dialog.Title = "Save the Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Computer computerreg in computerregister)
                {
                    writer.WriteLine(string.Join(",", computerreg.Name, computerreg.Date, computerreg.Computernumber, computerreg.Print_number, computerreg.Total));
                }
            }
            MessageBox.Show("Text file exported successfully :D");
        }





        private void btnExportWordc_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Word Documents|*.docx";
            dialog.Title = "Save the Word File";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            //

            string filePath = dialog.FileName;

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                foreach (Computer computer in computerregister)
                {
                    Paragraph paragraph = body.AppendChild(new Paragraph());
                    Run run = paragraph.AppendChild(new Run());

                    Text text = run.AppendChild(new Text());
                    text.Text = $"Name: {computer.Name}, Date: {computer.Date}, Computer number: {computer.Computernumber}, Number of prints: {computer.Print_number}, Total: {computer.Total} \r\n";
                }
            }

            MessageBox.Show("Word file exported successfully :D");
        }

        private void btnReadtxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files |*.txt";
            dialog.Title = "Save the Text File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;
            string[] lines = File.ReadAllLines(filePath);

            computerregister.Clear();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                Computer computer = new Computer();
                computer.Name = columns[0].Trim();
                computer.Date = Convert.ToDateTime(columns[1].Trim());
                computer.Computernumber= (columns[2].Trim());
                computer.Print_number = Convert.ToInt16(columns[3].Trim());
                computer.Total= Convert.ToDouble(columns[4].Trim());
                computerregister.Add(computer);
            }

            dgvComputer.DataSource = null;
            dgvComputer.DataSource = computerregister;
        }
    }

}
