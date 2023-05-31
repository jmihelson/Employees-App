using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunEmployeesApp.Tests.Controller
{
    public class EmployeeControllerTests
    {

        private IEmployeeRepository _employeeRepository;
        private object _employeeController;

        public EmployeeControllerTests() 
        {
            _employeeRepository = (IEmployeeRepository?)A.Fake<Controller.IEmployeeRepository>();
        }

        private class IEmployeeRepository
        {
            internal object GetAll()
            {
                throw new NotImplementedException();
            }
        }
        public void EmloyeeController_index_ReturnSuccess()
        {
            //Arrange
            var employees = A.Fake<IEnumerable<Employee>>();
            A.CallTo(() => _employeeRepository.GetAll()).Returns(employees);
            //Act
            var result = _employeeController.Index();
            //Assert - Object check action
            result.Should().BetOfType <Task<IActionResult>>();
        }
    }

    
}
