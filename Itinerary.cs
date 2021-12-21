
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Itinerary {

    public Itinerary() {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 10;
        itinerary_ID= new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        this.points_of_interest = new List<Point_of_interest>();
    }
    public Itinerary(string ID) {
        itinerary_ID = ID;
    }

    private string itinerary_ID;

    private string start_location;

    private string destination;

    private int cost;

    private int duration;

    private int distance;

    private List<Point_of_interest> points_of_interest;

    private bool is_active;


    public string Itinerary_ID { get => itinerary_ID; set => itinerary_ID = value; }
    public string Start_location { get => start_location; set => start_location = value; }
    public string Destination { get => destination; set => destination = value; }
    public int Cost { get => cost; set => cost = value; }
    public int Duration { get => duration; set => duration = value; }
    public int Distance { get => distance; set => distance = value; }
    public bool Is_active { get => is_active; set => is_active = value; }



    public void calculate_cost() {
        // TODO implement here
    }

    public void add_point_of_interest(Point_of_interest pointOfInterest) {
        // TODO implement here
        points_of_interest.Add(pointOfInterest);
    }

    public void remove_point_of_interest() {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void add_point_of_interest( string POI_ID) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void remove_point_of_interest( string POI_ID) {
        // TODO implement here
    }

}