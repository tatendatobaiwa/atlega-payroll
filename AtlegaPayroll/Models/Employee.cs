namespace AtlegaPayroll.Models;

public class Employee
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string OmangNumber { get; set; }
    public string Position { get; set; }
    public decimal BasicSalary { get; set; }
    public string BankAccountNumber { get; set; }
    public DateTime HireDate { get; set; }
}
