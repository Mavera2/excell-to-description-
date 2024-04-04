using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace excell_to_description
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyasec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası |*.xlsx";
            file.ShowDialog();
            string tamYol = file.FileName;
            string baglantiAdresi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tamYol + ";Extended Properties='Excel 12.0;IMEX=1;'";
            OleDbConnection baglanti = new OleDbConnection(baglantiAdresi);
            OleDbCommand komut = new OleDbCommand("Select * From [" + "Sayfa1" + "$]", baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void ciktial_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF dosyaları|*.pdf";
            saveFileDialog.Title = "PDF olarak Kaydet";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow) // Yeni eklenmiş boş satırı atlayın
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                                else
                                {
                                    pdfTable.AddCell(""); // Eğer hücre değeri null ise boş bir hücre ekleyin
                                }
                            }
                        }
                    }

                    doc.Add(pdfTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    doc.Close();
                }
            }
        }
    }
}
