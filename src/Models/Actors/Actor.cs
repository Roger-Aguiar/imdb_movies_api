using System;

namespace ImdbMovies.ActorModel
{
    public class Actor 
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Country {get; set;}
        public int AsActor{get; set;}
        public int AsDirector{get; set;}
        public int AsProducer{get; set;}
        public string ImdbLink{get; set;}
        public DateTime RegisterDate{get; set;}
        public DateTime LastUpdate{get; set;}
    }
}