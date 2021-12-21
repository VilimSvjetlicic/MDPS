
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Itinerary {

    public Itinerary() {
    }

    private string itinerary_ID;

    private string start_location;

    private string destination;

    private int cost;

    private int duration;

    private int distance;

    private HashSet<Point_of_interest> points_of_interest;

    public bool in_process;

    private bool is_active;

    public void calculate_cost() {
        // TODO implement here
    }

    public void add_point_of_interest() {
        // TODO implement here
    }

    public void remove_point_of_interest() {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void add_point_of_interest(POI_ID string) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void remove_point_of_interest(POI_ID string) {
        // TODO implement here
    }

}