using System.Collections.ObjectModel;

namespace AutocompleteSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Employee
    {
        public string? Name { get; set; }
        public string? Profile { get; set; }
        public string? Designation { get; set; }
        public string? ID { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public ViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee
            {
                Name = "Jessica Martinez",
                Profile = "Jessy.png",
                Designation = "Developer",
                ID = "E001",
            });
            Employees.Add(new Employee
            {
                Name = "Robert Lee",
                Profile = "Robert.png",
                Designation = "Developer",
                ID = "E002",
            });
            Employees.Add(new Employee
            {
                Name = "Andrew Fuller",
                Profile = "Andrew.png",
                Designation = "Team Lead",
                ID = "E003",
            });
            Employees.Add(new Employee
            {
                Name = "Sarah Davis",
                Profile = "Sarah.png",
                Designation = "Product Manager",
                ID = "E004",
            });
        }
    }

}
