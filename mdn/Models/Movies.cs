using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mdn.Models
{
    public class Movies
    {
        int MovieID { get; set; }
        string  MovieName { get; set; }
        DateTime ReleaseDate { get; set; }
        int RunningTime { get; set; }
        string MovieDescription { get; set; }
        string Genre { get; set; }
    }

    public class Actors
    {
        int ActorID { get; set; }
        int MovieID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }
        string CountryOfBirth { get; set; }
    }

    public class Writers
    {
        int WriterID { get; set; }
        int MovieID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }
        string CountryOfBirth { get; set; }

    }

    public class Producers
    {
        int ProducerID { get; set; }
        int MovieID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }
        string CountryOfBirth { get; set; }

    }

    public class Directors
    {
        int DirectorID { get; set; }
        int MovieID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        string PlaceOfBirth { get; set; }
        string CountryOfBirth { get; set; }

    }
}