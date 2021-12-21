using System;

namespace LV5_MDPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stvaranje sustava
            GreenGo_system greenGoSystem= new();
            
            // Stvaranje korisnika i dodavanje u sustav
            User firstUser = new User();
            User secondUser = new User();
            firstUser.fill_itinerary_data("Osijek","Pula", 5, 1200);
            secondUser.fill_itinerary_data("Osijek", "Pula", 5, 1200);
            greenGoSystem.add_user(firstUser);
            greenGoSystem.add_user(secondUser);


            // pozivanje implementirane metode
            greenGoSystem.generate_offer(firstUser.User_ID);
            greenGoSystem.generate_offer(secondUser.User_ID);

            // Korisnik ponovno popunjava željeno putovanje i sustav generira novu ponudu
            firstUser.fill_itinerary_data("Osijek", "Rijeka", 4, 1800);
            greenGoSystem.generate_offer(firstUser.User_ID);

    
            // Za provjeru, ispisani ID-jevi ponuđenih putovanja
            Console.WriteLine("ID-jevi ponuđenih putovanja prvog korisnika:\n");
            firstUser.printOffers();
            Console.WriteLine("\n\nID-jevi ponuđenih putovanja drugog korisnika:\n");
            secondUser.printOffers();
        }
    }
}
