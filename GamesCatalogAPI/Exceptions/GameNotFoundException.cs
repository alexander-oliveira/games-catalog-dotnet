using System;

namespace GamesCatalogAPI.Exceptions
{
    internal class GameNotFoundException : Exception
    {
        public GameNotFoundException() 
            : base("This game was not found in the database.")
        {
        }
    }
}