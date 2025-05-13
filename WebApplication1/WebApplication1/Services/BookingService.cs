using s30601_kolokwium1D.Models;
using System.Data.SqlClient;

namespace s30601_kolokwium1D.Services;

public class BookingService : IBookingService
{
    public readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=APBD;Integrated Security=True;";

    public async Task<BookingDTO> GetBooking(int id)
    {
        string sql = "SELECT * FROM Bookings WHERE Id = @id";
        using (var connection = new SqlConnection(_connectionString))
        {
            using var command = connection.SqlCommand(sql);
            command.Parameters.AddWithValue("@id", id);
            
        }
        
    }

    
}