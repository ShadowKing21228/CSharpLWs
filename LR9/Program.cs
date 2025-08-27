namespace LR9;

public record Movie(string Title, int Duration, string Genre);
    
public record CinemaHall(int HallNumber, int Capacity, List<string> Seats);

public class Cinema
{
    private List<Movie> _movies = [];
    private List<CinemaHall> _halls = [];
    private Dictionary<DateTime, Tuple<Movie, CinemaHall>> _schedule = new();
    public void AddMovie(string title, int duration, string genre)
    {
        _movies.Add(new Movie(title, duration, genre));
        Console.WriteLine($"Movie '{title}' added!");
    }

    public void AddHall(int number, int capacity)
    {
        var seats = GenerateSeats(capacity);
        _halls.Add(new CinemaHall(number, capacity, seats));
        Console.WriteLine($"Hall {number} added with {capacity} seats!");
    }

    public void ScheduleMovie(DateTime time, string movieTitle, int hallNumber)
    {
        var movie = FindMovie(movieTitle);
        var hall = FindHall(hallNumber);

        if (movie == null || hall == null)
        {
            Console.WriteLine("Movie or hall not found!");
            return;
        }

        _schedule.Add(time, Tuple.Create(movie, hall));
        Console.WriteLine($"Scheduled '{movieTitle}' in hall {hallNumber} at {time}");
    }

    public void BookTicket(DateTime time, string seat, string customerName)
    {
        if (!_schedule.ContainsKey(time))
        {
            Console.WriteLine("No movie scheduled at this time!");
            return;
        }
        var hall = _schedule[time].Item2;
        if (!IsSeatAvailable(hall, seat))
        {
            Console.WriteLine("Invalid seat number!");
            return;
        }

        ReserveSeat(hall, seat);
        Console.WriteLine($"Booked seat {seat} for {customerName}");
    }

    public void PrintSchedule()
    {
        Console.WriteLine("Current schedule:");
        foreach (var entry in _schedule)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value.Item1.Title} in hall {entry.Value.Item2.HallNumber}");
        }
    }
    
    private List<string> GenerateSeats(int capacity)
    {
        return Enumerable.Range(1, capacity)
            .Select(i => $"Seat {i}")
            .ToList();
    }
    
    private Movie? FindMovie(string title) =>
        _movies.FirstOrDefault(m => m.Title == title);

    private CinemaHall? FindHall(int hallNumber) =>
        _halls.FirstOrDefault(h => h.HallNumber == hallNumber);
    
    private bool IsSeatAvailable(CinemaHall hall, string seat) =>
        hall.Seats.Contains(seat);

    private void ReserveSeat(CinemaHall hall, string seat) =>
        hall.Seats.Remove(seat);
}

public class Program
{
    public static void Main()
    {
        var cinema = new Cinema();
        cinema.AddMovie("The Matrix", 150, "Sci-Fi");
        cinema.AddHall(1, 50);
        cinema.ScheduleMovie(new DateTime(2023, 12, 25, 18, 0, 0), "The Matrix", 1);
        cinema.BookTicket(new DateTime(2023, 12, 25, 18, 0, 0), "Seat 5", "John Doe");
        cinema.PrintSchedule();
    }
}