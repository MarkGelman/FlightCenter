using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter
{
    class Administrator:IPoco
    {
        long Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Level { get; set; }
        long UserId { get; set; }

        public Administrator ()
        {

        }

        public Administrator(int id, string firstName, string lastName, int level, long userId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Level = level;
            UserId = userId;
        }




    }
}
