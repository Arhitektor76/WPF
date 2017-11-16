using System.Collections.ObjectModel;
using MVVM.Model;
using System.Collections.Generic;

namespace MVVM.Model
{
    public static class Task_manager
    {
        private static ObservableCollection<Task> _tasks;

        public static ObservableCollection<Task> Alltasks
        {
            get
            {
                if (_tasks == null)
                    _tasks = new Task();
                return _tasks;
            }
        }
    }
}
