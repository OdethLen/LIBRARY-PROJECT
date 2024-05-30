
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace LIBRARY_PROJECT
{
    public partial class FrmBook : Form
    {
        ArrayList dataregister = new ArrayList();
        public FrmBook()
        {
            InitializeComponent();
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            Book book = new Book();


            if (txtName.Text == "")
            {
                MessageBox.Show("Field NAME cannot be blank");

            }
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Field TITLE cannot be blank");

            }

            if (txtAuthor.Text == "")
            {
                MessageBox.Show("Field AUTHOR cannot be blank");

            }

            if (txtPublisher.Text == "")
            {
                MessageBox.Show("Field PUBLISHER cannot be blank");
                return;
            }

            book.Name = txtName.Text;
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Publisher = txtPublisher.Text;
            book.Date = Convert.ToDateTime(dtpdate.Text);
            book.Enddate = Convert.ToDateTime(dtpEnddate.Text);

            dataregister.Add(book);
            dgvBookregister.DataSource = null; //Limpia cualquier dato previamente mostrado (se actualiza automaticamente)
            dgvBookregister.DataSource = dataregister; //Data source =funte de datos, indicas al dgv que la fuente de datos es el Array list llamado data register
        }

        private void btnNewbookr_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            dtpdate.Value = DateTime.Now;
            dtpEnddate.Value = DateTime.Now;
        }

        //Método paraa Guardar el archivo de texto 
        public void SaveTextFile()
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
                foreach (Book bookregister in dataregister)
                {
                    writer.WriteLine(string.Join(",", bookregister.Name, bookregister.Title, bookregister.Author, bookregister.Publisher, bookregister.Date, bookregister.Enddate));
                }
            }
            MessageBox.Show("Text file exported successfully :D");

        }

        //Método para abrir un archivo de texto
        public void Opentextfile()
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

            dataregister.Clear();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                Book book = new Book();
                book.Name = columns[0].Trim();
                book.Title = columns[1].Trim();
                book.Author = columns[2].Trim();
                book.Publisher = columns[3].Trim();
                book.Date = Convert.ToDateTime(columns[4].Trim());
                book.Enddate = Convert.ToDateTime(columns[5].Trim());
                dataregister.Add(book);
            }

            dgvBookregister.DataSource = null;
            dgvBookregister.DataSource = dataregister;
        }


        private void btnExporttxt_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Word Documents|*.docx";
            dialog.Title = "Save the Word File";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                foreach (Book book in dataregister)
                {
                    Paragraph paragraph = body.AppendChild(new Paragraph());
                    Run run = paragraph.AppendChild(new Run());

                    Text text = run.AppendChild(new Text());
                    text.Text = $"Name: {book.Name}, Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Date: {book.Date}, End Date: {book.Enddate}\r\n";
                }
            }

            MessageBox.Show("Word file exported successfully :D");

        }

        private void btnOpentxtFile_Click(object sender, EventArgs e)
        {
            Opentextfile();
        }

        private void btnExportexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel Worksheets|*.xlsx";
            dialog.Title = "Save the Excel File";
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string filePath = dialog.FileName;
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                // Agregar una hoja de cálculo al documento
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());
                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                sheets.Append(sheet);

                // Escribir los datos en la hoja de cálculo
                foreach (Book book in dataregister)
                {
                    Row excelRow = new Row();

                    // Método para crear una celda y asignarle un valor
                    void AddCell(string value)
                    {
                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(value);
                        excelRow.AppendChild(cell);
                        //Agregar el valor en una celda 
                    }

                    // Agregar las celdas para cada propiedad del libro

                    AddCell(book.Title);
                    AddCell(book.Author);
                    AddCell(book.Publisher);
                    AddCell(book.Date.ToString()); // Convertir DateTime a string
                    AddCell(book.Enddate.ToString()); // Convertir DateTime a string o asignar null si EndDate es nulo

                    // Agregar la fila a la hoja de cálculo
                    worksheetPart.Worksheet.GetFirstChild<SheetData>().AppendChild(excelRow);
                }

                MessageBox.Show("Excel document successfully saved :D");
            }



        }


    }

}

