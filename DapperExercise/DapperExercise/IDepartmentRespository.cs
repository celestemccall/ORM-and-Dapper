using System;
namespace DapperExercise
{
	public interface IDepartmentRespository
	{
		public IEnumerable<Department> GetAllDepartments();

		public void InsertDepartment(string newDepartmentName);
	}
}

