using Kartonowanie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

using Microsoft.Office.Interop.Excel;

namespace Kartonowanie
{
    public partial class Forma : Form
    {
        Porownywarka porownywarka = new Porownywarka();
        public Forma()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void ReadBoxesbtn_Click(object sender, EventArgs e)
        {
            var csvReader = new CSVReader();
            porownywarka.Boxes = csvReader.GetBoxes().ToList();

            if (porownywarka.Boxes.Count > 0) label1.Text = "GIT";
            if (porownywarka.Boxes.Count > 0 && porownywarka.Items.Count > 0)
            {
                button1.Enabled = true;              
            }
        }

        private void ReadItemsBtn_Click(object sender, EventArgs e)
        {
            var csvReader = new CSVReader();
            porownywarka.Items = csvReader.GetItems().ToList();
            if (porownywarka.Items.Count > 0) label2.Text = "GIT";
            if (porownywarka.Boxes.Count > 0 && porownywarka.Items.Count > 0)
            {
                button1.Enabled = true;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach(var item in porownywarka.Items)
            {

                Output output = new Output();
                Box karton = porownywarka.ZnajdzKartonDlaProduktu(item);

                output.Item = item;
                output.Box = karton;

                if (item.Category.Contains("Silniki")
                    || item.Category.Contains("Serwomotory")
                    )
                {
                    output.IsActive = false;
                }
                else output.IsActive = true;
                output.ZostaloPowietrza = porownywarka.ZnajdzObjetosc(item,karton);
                if((output.IsActive == false) || (output.Box.Id == -1) || (output.Item.H == 0) || (output.Item.W == 0) || (output.Item.L == 0))
                {
                    //gowno
                }else
                porownywarka.Outputs.Add(output);
            }
            if (porownywarka.Outputs.Count > 0)
            {
                button2.Enabled = true;
                label3.Text = "ZAJEBISCIE, ZAPISZ SE TO";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable("IGor");
            dt.Columns.Add("Symbol", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Kategoria", typeof(string));
            dt.Columns.Add("Dlugosc", typeof(decimal));
            dt.Columns.Add("Szerokosc", typeof(decimal));
            dt.Columns.Add("Wysokosc", typeof(decimal));
            dt.Columns.Add("KartonName", typeof(string));
            dt.Columns.Add("IleZostalo", typeof(decimal));
            int id = 1;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "XLSX|*.xlsx";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var output in porownywarka.Outputs)
            {
                var row = dt.NewRow();

                row[0] = output.Item.Symbol;
                row[1] = output.Item.Name;

                row[2] = output.Item.Category;
                row[3] = output.Item.L/10;
                row[4] = output.Item.W / 10;
                row[5] = output.Item.H / 10;
                row[6] = output.Box.Name;
                row[7] = output.ZostaloPowietrza/1000/5000;

                dt.Rows.Add(row);
            }

            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dt, "WorksheetName");
            wb.SaveAs(saveFileDialog1.FileName);

                Microsoft.Office.Interop.Excel.Application xlapp;
                Microsoft.Office.Interop.Excel.Workbook xlworkbook;
                xlapp = new Microsoft.Office.Interop.Excel.Application();

                xlworkbook = xlapp.Workbooks.Open(saveFileDialog1.FileName, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlapp.Visible = true;
            }
        }
    }
}
