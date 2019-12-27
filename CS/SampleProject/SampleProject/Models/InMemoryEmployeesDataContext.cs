using System.Collections.Generic;

namespace SampleProject.Models {
    public class InMemoryEmployeesDataContext : InMemoryDataContext<Employee> {
        public ICollection<Employee> Employees => ItemsInternal;
        protected override IEnumerable<Employee> Source => SampleData.SampleData.DataGridEmployees;
        protected override int GetKey(Employee item) => item.ID;
        protected override void SetKey(Employee item, int key) => item.ID = key;
    }
}
