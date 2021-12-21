
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Premium_registered_user : User , Registered_user {

    public Premium_registered_user() {
    }

    public string userName;

    public string eMail;

    public string phoneNumber;

    private string bank_account;

    private string password;

    public void enable_trailtracking() {
        // TODO implement here
    }

    public void pay_subscription() {
        // TODO implement here
    }

    public void include_discount(string discount_code)
    {
        throw new NotImplementedException();
    }

    public void customize_itinerary(string itinerary_ID)
    {
        throw new NotImplementedException();
    }

    public void add_review(string itinerary_ID, string comment)
    {
        throw new NotImplementedException();
    }

    public void get_itinerary(string itinerary_ID)
    {
        throw new NotImplementedException();
    }
}