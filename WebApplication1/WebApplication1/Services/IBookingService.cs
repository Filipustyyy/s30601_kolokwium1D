using s30601_kolokwium1D.Models;

namespace s30601_kolokwium1D.Services;

public interface IBookingService
{
    Task<BookingDTO> GetBooking(int id);

}