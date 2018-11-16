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
        private RelayCommand _addProjectCommand;
        private RelayCommand _removeProjectCommand;
        private RelayCommand _addMemberCommand;
        private RelayCommand _removeMemberCommand;
        private RelayCommand _addItemCommand;
        private RelayCommand _removeItemCommand;
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
        }

        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value; 
                OnPropertyChanged();
            }
        }

        public RelayCommand AddProjectCommand
        {
            get { return _addProjectCommand; }
            set
            {
                _addProjectCommand = value; 
                OnPropertyChanged();
            }
        }

        private void AddProject()
        {
            _projects.Add(new Project(_projectTitle));
        }

        private void RemoveProject()
        {
            _projects.Remove(_selectedProject);
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

        public RelayCommand RemoveProjectCommand
        {
            get { return _removeProjectCommand; }
            set
            {
                _removeProjectCommand = value; 
                OnPropertyChanged();
            }
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

        public RelayCommand AddMemberCommand
        {
            get { return _addMemberCommand; }
            set { _addMemberCommand = value; }
        }

        public RelayCommand RemoveMemberCommand
        {
            get { return _removeMemberCommand; }
            set { _removeMemberCommand = value; }
        }

        public RelayCommand AddItemCommand
        {
            get { return _addItemCommand; }
            set { _addItemCommand = value; }
        }

        public RelayCommand RemoveItemCommand
        {
            get { return _removeItemCommand; }
            set { _removeItemCommand = value; }
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
