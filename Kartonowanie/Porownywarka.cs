using Kartonowanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartonowanie
{
    public class Porownywarka
    {
        public List<Box> Boxes;
        public List<Item> Items;
        public List<Output> Outputs;
        public decimal Zapas = 3;

        public Porownywarka()
        {
            Boxes = new List<Box>();
            Items = new List<Item>();
            Outputs = new List<Output>();
        }

        public Box ZnajdzKartonDlaProduktu(Item item)
        {
            foreach(var box in Boxes)
            {
                if (  box.H >= item.H + Zapas && box.L > item.L + Zapas  && box.W > item.W + Zapas
                    || box.H >= item.H + Zapas && box.W > item.L + Zapas  && box.L > item.W + Zapas 
                    || box.L >= item.H + Zapas && box.H > item.L + Zapas  && box.W > item.W + Zapas 
                    || box.L >= item.H + Zapas && box.W > item.L + Zapas  && box.H > item.W + Zapas 
                    || box.W >= item.H + Zapas && box.H > item.L + Zapas  && box.L > item.W + Zapas 
                    || box.W >= item.H + Zapas && box.L > item.L + Zapas  && box.H > item.W + Zapas )
                {
                    return box;
                }          
            }
            return new Box() { Id=-1};
        }

        public decimal ZnajdzObjetosc(Item item, Box box)
        {
            return box.Objetosc - item.Objetosc;
        }



    }
}
