using System;

// Base Customer class
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor
    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Make a reservation
    public void MakeReservation(Reservation reservation)
    {
        Console.WriteLine($"{FirstName} made a reservation.");
    }
}

// Reservation class
public class Reservation
{
    public int ReservationNo { get; set; }

    // Constructor
    public Reservation(int reservationNo)
    {
        ReservationNo = reservationNo;
    }
}

// Seat class
public class Seat
{
    public string SeatNo { get; set; }

    // Constructor
    public Seat(string seatNo)
    {
        SeatNo = seatNo;
    }

    public void Reserve()
    {
        Console.WriteLine($"Seat {SeatNo} reserved.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("John", "Doe");
        Reservation reservation = new Reservation(101);
        Seat seat1 = new Seat("12A");

        customer.MakeReservation(reservation);
        seat1.Reserve();
    }
}
