using System;

namespace GamesCatalogAPI.Exceptions
{
    internal class GameAlreadyExistsException : Exception
    {
        public GameAlreadyExistsException() 
            : base("This game is already present in the database.")
        {
        }
    }
}