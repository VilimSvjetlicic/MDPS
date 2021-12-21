
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Free_registered_user : User , Registered_user {

    public Free_registered_user() {
    }

    public string userName;

    public string eMail;

    public string phoneNumber;

    private string password;

}