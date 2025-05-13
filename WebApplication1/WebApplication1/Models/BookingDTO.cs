namespace s30601_kolokwium1D.Models;

public class BookingDTO
{
    public int BookId { get; set; }
    public int GuestId { get; set; }
    public int EmpId { get; set; }
    public DateTime Date { get; set; }
}

public class GuestDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public class EmployeeDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int EmpNo { get; set; }
}

public class AttractionDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}