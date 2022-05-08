using eebebek.DtoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eebebek.Common
{
    public sealed class Cart
    {
        private Cart() { }

        private static List<Urun> _stocks = new List<Urun>();

        public static List<Urun> Stocks
        {
            get
            {
                if (_stocks == null)
                {
                    _stocks = new List<Urun>();
                }
                return _stocks;
            }
        }
        public static void  AddToStocks(Urun stock)
        {
            if (stock == null)
                return;

            _stocks.Add(stock);
        }

        public static void RemoveFromStocks(int stockId)
        {
            _stocks = _stocks.Where(x => x.Id != stockId).ToList();
        }


    }
}
