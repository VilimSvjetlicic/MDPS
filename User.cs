
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class User {

    public User() {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 10;
        User_ID = new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());

        this.offers = new List<string>();
    }

    public string userName;

    public string eMail;

    private List<string> offers;

    private string user_name;

    private string phone_number;

    private Itinerary itinerary_data;

    public string active_itinerary_ID;

    private string user_ID;

    public string User_ID { get => user_ID; set => user_ID = value; }
    public Itinerary Itinerary_data { get => itinerary_data; set => itinerary_data = value; }

    public void fill_itinerary_data(string start_location, string destination, int duration, int cost) {
        // TODO implement here
        Itinerary exampleItinerary = new Itinerary();
        exampleItinerary.Start_location = start_location;
        exampleItinerary.Cost = cost;
        exampleItinerary.Destination = destination;
        exampleItinerary.Duration = duration;

        active_itinerary_ID = exampleItinerary.Itinerary_ID;
        itinerary_data = exampleItinerary;
    }

    public void register() {
        // TODO implement here
    }


    /// <summary>
    /// @param string
    /// </summary>
    public void accept_offer( string itinerary_ID) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void finish_itinerary( string itinerary_ID) {
        // TODO implement here
    }


    /// <summary>
    /// @param string
    /// </summary>
    public void set_active_itinerary( string itinerary_ID) {
        // TODO implement here
    }
    public void add_offer(string itinerary_ID) {
        offers.Add(itinerary_ID);
    }

    public void printOffers() {
        foreach (string offer in offers) {
            Console.WriteLine(offer);
                }
    }

}