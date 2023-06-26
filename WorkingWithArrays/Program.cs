// Hardcoded array of Tuples
var episodes = new (int season, int episode, string title, int length)[]
{ // Ini
    (1, 1, "Simpsons Roasting on an Open Fire", 22),
    (1, 2, "Bart the Genius", 22),
    (1, 3, "Homer's Odyssey", 22),
    (1, 4, "There's No Disgrace Like Home", 23),
    (1, 5, "Bart the General", 22),
    (1, 6, "Moaning Lisa", 22),
    (1, 7, "The Call of the Simpsons", 22),
    (1, 8, "The Telltale Head", 22),
    (1, 9, "Life on the Fast Lane", 22),
    (1, 10, "Homer's Night Out", 22),
};

// Group seasons by using LINQ's group by method.
var seasons = episodes.GroupBy(e => e.season);

// Calculate Average of each season.
var seasonAverages = seasons.Select(s => new { Season = s.Key, AverageLength = s.Average(e => e.length) });

// Display the top three longest seasons
var topThree = seasonAverages.OrderByDescending(s => s.AverageLength).Take(3);

foreach (var season in topThree)
{
    Console.WriteLine($"Season {season.Season}: {season.AverageLength} minutes");
}