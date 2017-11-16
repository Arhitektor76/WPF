using System.Collections.ObjectModel;
using MVVM.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;
using MVVM.Infrastructure;

namespace MVVM.View_Model
{
    public class MainWindowViewModel : ViewModelBase
    {
        Task _currentTask;
        public Task CurrentTask
        {
            get
            {
                if (_currentTask == null)
                    _currentTask = new Task();
                return _currentTask;
            }
            set
            {
                _currentTask = value;
                OnPropertyChanged("CurrentTask");
            }
        }

        ObservableCollection<Task> _tasks;
        public ObservableCollection<Task> Tasks
        {
            get
            {
                if (_tasks == null)
                    _tasks = Task_manager.Alltasks;
                return _tasks;
            }
        }

        RelayCommand _addClientCommand;
        public ICommand AddClient
        {
            get
            {
                if (_addClientCommand == null)
                    _addClientCommand = new RelayCommand(ExecuteAddClientCommand, CanExecuteAddClientCommand);
                return _addClientCommand;
            }
        }

        public void ExecuteAddClientCommand(object parameter)
        {
            Tasks.Add(CurrentTask);
            CurrentTask = null;
        }

        public bool CanExecuteAddClientCommand(object parameter)
        {
            if (string.IsNullOrEmpty(""/*CurrentTask.FirstName*/) ||
                string.IsNullOrEmpty(""/*CurrentTask.LastName*/))
                return false;
            return true;
        }

        protected override void OnDispose()
        {
            this.Tasks.Clear();
        }
    }
}
