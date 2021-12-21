
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Registered_user {

    /// <summary>
    /// @param string
    /// </summary>
    public void include_discount(discount_code string);

    /// <summary>
    /// @param string
    /// </summary>
    public void customize_itinerary(itinerary_ID string);

    /// <summary>
    /// @param string 
    /// @param string
    /// </summary>
    public void add_review(itinerary_ID string, comment string);

    /// <summary>
    /// @param string
    /// </summary>
    public void get_itinerary(itinerary_ID string);

}