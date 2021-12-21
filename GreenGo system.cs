
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

private class GreenGo_system {

    private GreenGo_system() {
    }

    private HashSet<Itinerary> itineraries;

    private HashSet<User> users;

    private HashSet<Service> services;

    /// <summary>
    /// @param string 
    /// @param Itinerary
    /// </summary>
    public void generate_offer(user_ID string, itinerary Itinerary) {
        // TODO implement here
    }

    /// <summary>
    /// @param Itinerary
    /// </summary>
    public void convert_itinerary_data_to_offer(given_itinerary Itinerary) {
        // TODO implement here
    }

    /// <summary>
    /// @param string 
    /// @param string 
    /// @param string 
    /// @param int 
    /// @param int 
    /// @param int
    /// </summary>
    public void generate_itinerary(ID string, start_location string, destination string, cost int, duration int, distance int) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void send_offer(itinerary_ID string) {
        // TODO implement here
    }

    /// <summary>
    /// @param User
    /// </summary>
    public void add_user(user User) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void remove_user(user_ID string) {
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
    public void get_user_itinerary_data(user_ID string) {
        // TODO implement here
    }

    /// <summary>
    /// @param string
    /// </summary>
    public void add_service(service_ID string) {
        // TODO implement here
    }

}