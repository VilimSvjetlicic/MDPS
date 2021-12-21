
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Point_of_interest {

    public Point_of_interest() {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 10;
        POI_ID = new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    private int cost;

    private string location;

    private string POI_ID;

    /// <summary>
    /// @param string
    /// </summary>
    public void update_location( string location) {
        // TODO implement here
    }

    /// <summary>
    /// @param int
    /// </summary>
    public void update_cost( int cost) {
        // TODO implement here
    }

}