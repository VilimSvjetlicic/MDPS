
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Registered_user {

    /// <summary>
    /// @param string
    /// </summary>
    public void include_discount( string discount_code);

    /// <summary>
    /// @param string
    /// </summary>
    public void customize_itinerary( string itinerary_ID);

    /// <summary>
    /// @param string 
    /// @param string
    /// </summary>
    public void add_review( string itinerary_ID,  string comment);

    /// <summary>
    /// @param string
    /// </summary>
    public void get_itinerary( string itinerary_ID);

}