using Kartonowanie.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartonowanie
{
    public class CSVReader
    {

        public IEnumerable<Box> GetBoxes()
        {
            var boxes = new List<Box>();
            string[] read;
            char[] seperators = { ';' };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                String data;
                int i = 1;
                while ((data = sr.ReadLine()) != null)
                {

                    Box newBox = new Box();
                    read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                    newBox.Id = i;
                    newBox.Name = read[0];
                    newBox.L = Decimal.Parse(read[1]) * 10;
                    newBox.W = Decimal.Parse(read[2]) * 10;
                    newBox.H = Decimal.Parse(read[3]) * 10;
                    newBox.Weight = Decimal.Parse(read[4]);
                    boxes.Add(newBox);
                    i++;
                }
            }
            return boxes;
        }

        public IEnumerable<Item> GetItems()
        {

            var items = new List<Item>();
            string[] read;
            char[] seperators = { ';' };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                String data;
                int i = 1;
                while ((data = sr.ReadLine()) != null)
                {

                    Item newItem = new Item();
                    read = data.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

                    newItem.Id = i;
                    newItem.Symbol = read[0];
                    newItem.Name = read[1];
                    newItem.Category = read[2];
                    newItem.Weight = Decimal.Parse(read[3]);
                    newItem.L = Decimal.Parse(read[4]) * 10;
                    newItem.W = Decimal.Parse(read[5]) * 10;
                    newItem.H = Decimal.Parse(read[6]) * 10;

                    items.Add(newItem);
                    i++;
                }
            }
            return items;
        }
    }
}
