using NguyenThiThuHa231.Models;
using Microsoft.EntityFrameworkCore;
namespace NguyenThiThuHa231.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

    }
    public DbSet<Employee> Employee {get; set;}
}