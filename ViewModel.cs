using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DimselabUniversalApp.Annotations;
using GalaSoft.MvvmLight.Command;

namespace DimselabUniversalApp
{
    class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Project> _projects;

        private Project _selectedProject;
        private Member _selectedMember;
        private Item _selectedItem;

        private RelayCommand _addProjectCommand;
        private RelayCommand _removeProjectCommand;
        private RelayCommand _addMemberCommand;
        private RelayCommand _removeMemberCommand;
        private RelayCommand _addItemCommand;
        private RelayCommand _removeItemCommand;

        private string _itemName;
        private string _itemID;
        private string _itemReturnDate;
        private string _projectTitle; 
        private string _memberName;
        private string _memberClass;

        public ViewModel()
        {
            _projects = new ObservableCollection<Project>();
            _projects.Add(new Project("Project1"));
            _projects.Add(new Project("Project2"));
            _projects.Add(new Project("Project3"));

            _projects[0].AddItem();
            _projects[0].AddMember();
            _projects[0].AddItem();
            _projects[0].AddMember();
            _projects[2].AddItem();
            _projects[2].AddMember();

            AddProjectCommand = new RelayCommand(AddProject);
            RemoveProjectCommand = new RelayCommand(RemoveProject);
            AddMemberCommand = new RelayCommand(AddMember);
            RemoveMemberCommand = new RelayCommand(RemoveMember);
            //AddItemCommand = new RelayCommand();
        }

        #region selected things
        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value; 
                OnPropertyChanged();
            }
        }
        public Member SelectedMember
        {
            get { return _selectedMember; }
            set
            {
                _selectedMember = value;
                OnPropertyChanged();
            }
        }
        public Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }


        #endregion

        #region RelayCommands
        public RelayCommand AddProjectCommand
        {
            get { return _addProjectCommand; }
            set
            {
                _addProjectCommand = value; 
                OnPropertyChanged();
            }
        }
        public RelayCommand RemoveProjectCommand
        {
            get { return _removeProjectCommand; }
            set
            {
                _removeProjectCommand = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddMemberCommand
        {
            get { return _addMemberCommand; }
            set
            {
                _addMemberCommand = value; 
                OnPropertyChanged();
            }
        }
        public RelayCommand RemoveMemberCommand
        {
            get { return _removeMemberCommand; }
            set
            {
                _removeMemberCommand = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddItemCommand
        {
            get { return _addItemCommand; }
            set
            {
                _addItemCommand = value; 
                OnPropertyChanged();
            }
        }
        public RelayCommand RemoveItemCommand
        {
            get { return _removeItemCommand; }
            set
            {
                _removeItemCommand = value; 
                OnPropertyChanged();
            }
        }

        

        #endregion

        private void AddProject()
        {
            _projects.Add(new Project(_projectTitle));
        }
        private void RemoveProject()
        {
            _projects.Remove(_selectedProject);
        }

        private void AddMember()
        {
            _selectedProject.Members.Add(new Member(_memberName, _memberClass));
        }
        private void RemoveMember()
        {
            _selectedProject.Members.Remove(_selectedMember);
        }

        private void AddItem()
        {
            _selectedProject.Items.Add(new Item(_itemName, _itemID, _itemReturnDate));
        }
        private void RemoveItem()
        {
            _selectedProject.Members.Remove(_selectedMember);
        }

        public ObservableCollection<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }

        public string ProjectTitle
        {
            get { return _projectTitle; }
            set { _projectTitle = value; }
        }
        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
        public string MemberClass
        {
            get { return _memberClass; }
            set { _memberClass = value; }
        }
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        public string ItemId
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        public string ItemReturnDate
        {
            get { return _itemReturnDate; }
            set { _itemReturnDate = value; }
        }


        #region MyRegion
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
