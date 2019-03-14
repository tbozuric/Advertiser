using System.Collections.Generic;
using System.Linq;
using BaseLib;
using BaseLib.ViewInterfaces;
using DomainModel;
using DomainModel.Repositories;

namespace Controller
{
    public class EmployeeController
    {
        public void AddNewEmployee(IAddEmployeeView inForm, IRepository<Employee> employeeRepository)
        {
            var oib = inForm.Oib;
            var surname = inForm.Surname;
            var name = inForm.Name;
            var employee = new Employee(oib, surname, name);
            employeeRepository.Add(employee);
        }

        public void ShowAddEmployee(IAddEmployeeView inForm)
        {
            inForm.ShowViewModal();
        }

        public IList<Employee> GetAllEmployees(IRepository<Employee> employeeRepository)
        {
            return employeeRepository.All().ToList();
        }

        public void RemoveEmployee(IRemoveEmployeeView inForm, IRepository<Employee> repository)
        {
            var employee = inForm.EmployeeData;
            var oib = employee.Oib;
            repository.Delete(repository.FindBy(x => x.Oib == oib));
        }

        public void ShowRemoveEmployee(IRemoveEmployeeView inForm)
        {
            inForm.ShowViewModal();
        }

        public void ViewEmployees(IShowView<Employee> inForm, IRepository<Employee> employeeRepository,
            IMainController controller)
        {
            IList<Employee> employees = employeeRepository.All().ToList();
            inForm.ShowModal(controller, employees);
        }


        public void ShowAddEmployeeToVideoWall(IAddEmployeeToVideoWallView inForm)
        {
            inForm.ShowViewModal();
        }
    }
}