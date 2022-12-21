using LeaveManagement.Web.Data;
using System.Collections.Generic;

namespace LeaveManagement.Web.Models
{
    public class EmployeeAllocationVM:EmployeeListVM
    {
        public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
