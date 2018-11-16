using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DimselabUniversalApp.Annotations;

namespace DimselabUniversalApp
{
    class Item
    {
        private string _itemName;
        private int _itemID;
        private string _returnDate;

        public Item(string itemName, int itemID, string returnDate)
        {
            _itemName = itemName;
            _itemID = itemID;
            _returnDate = returnDate;
        }

        public string ItemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value; 
            }
        }

        public int ItemId
        {
            get { return _itemID; }
            set
            {
                _itemID = value; 
            }
        }

        public string ReturnDate
        {
            get { return _returnDate; }
            set
            {
                _returnDate = value;
            }
        }

        public override string ToString()
        {
            return "Item name: " + _itemName + "\tItem ID: " + _itemID + "\tReturn date: " + _returnDate.ToString();
        }
    }
}
