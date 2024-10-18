using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NguyenThiThuHa231.Models;
[Table("Employee")]
public class Employee
{
    [Key]
    public int EmployeeID { get; set; }
    public String FullName { get; set; }
    public DateTime NgayThangNam { get; set; }
}