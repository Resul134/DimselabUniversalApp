using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Member> _members = new ObservableCollection<Member>();
        private ObservableCollection<Item> _items = new ObservableCollection<Item>();

        public Project(string title)
        {
            _title = title;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public ObservableCollection<Member> Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; }
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
