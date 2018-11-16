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
    class Project
    {
        private string _title;
        private List<Member> _members = new List<Member>();
        private List<Item> _items = new List<Item>();

        public Project(string title)
        {
            _title = title;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value; 
            }
        }

        public List<Member> Members
        {
            get { return _members; }
            set
            {
                _members = value;
            }
        }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value; 
            }
        }

        public void AddItem()
        {
            _items.Add(new Item("Drill", 12, "12th novemeber"));
        }

        public void AddMember()
        {
            _members.Add(new Member("Thomas","1B"));
        }
        public override string ToString()
        {
            return "Project title: " + _title.ToString();
        }
    }
}
