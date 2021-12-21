
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GreenGo_system {

    public GreenGo_system() {
            this.itineraries = new List<Itinerary>();
            this.users = new List<User>();
            this.services = new List<Service>();
    }

    private List<Itinerary> itineraries;

    private List<User> users;

    private List<Service> services;


    /// <summary>
    /// @param string 
    /// @param Itinerary
    /// </summary>
    public void generate_offer(string user_ID) {
        // TODO implement here

        //// kod bez privremenih varijabli
        //
        //string itinerary_ID=generate_itinerary(convert_itinerary_data_to_offer(get_user_itinerary_data(user_ID)));
        //send_offer(itinerary_ID,user_ID);


        // kod s privremenim varijablama, ali razumljiviji po Sequence Diagram-u iz LV4

        Itinerary temp = new Itinerary();
        temp =get_user_itinerary_data(user_ID);

        temp=convert_itinerary_data_to_offer(temp);

        string temp_ID=generate_itinerary(temp);

        send_offer(temp_ID, user_ID);
    }

    /// <summary>
    /// @param Itinerary
    /// </summary>
    public Itinerary convert_itinerary_data_to_offer(Itinerary given_itinerary ) {
        // TODO implement here
        // Ovdje bi bio algoritam koji pretražuje i stvara sliènu ponudu danoj, ali sada æe samo prepisati iste vrijednosti i dodati neispunjene
        given_itinerary.Distance = 590;

        Point_of_interest pointOfInterest1 = new Point_of_interest();
        Point_of_interest pointOfInterest2 = new Point_of_interest();
        given_itinerary.add_point_of_interest(pointOfInterest1);
        given_itinerary.add_point_of_interest(pointOfInterest2);

        given_itinerary.Is_active = false;
        return given_itinerary;
    }

    /// <summary>
    /// @param string 
    /// @param string 
    /// @param string 
    /// @param int 
    /// @param int 
    /// @param int
    /// </summary>
    public string generate_itinerary(Itinerary itinerary) {
        // TODO implement here
        itineraries.Add(itinerary);
        return itinerary.Itinerary_ID;
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void send_offer( string itinerary_ID, string user_ID) {
        // TODO implement here
        foreach (User user in users)
        {
            if (user_ID == user.User_ID)
            {
                user.add_offer(itinerary_ID);
            }
        }
    }

    /// <summary>
    /// @param User
    /// </summary>
    public void add_user( User user) {
        // TODO implement here
        users.Add(user);
    }

    /// <summary>
    /// @param sting
    /// </summary>
    public void remove_user( string user_ID) {
        // TODO implement here
    }

    public void create_backup() {
        // TODO implement here
    }

    public void send_discounts() {
        // TODO implement here
    }

    public void change_itinerary_activity() {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public Itinerary get_user_itinerary_data( string user_ID) {
        // TODO implement here
        foreach (User user in users) 
        {
            if (user_ID == user.User_ID)
            {
                return user.Itinerary_data;
            }
        }
        return null;
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void add_service( string service_ID) {
        // TODO implement here
    }

   
}