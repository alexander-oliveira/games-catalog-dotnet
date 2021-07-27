using System;

namespace GamesCatalogAPI.ViewModels
{
    public class GameViewModel
    {
        public Guid Id {get; set;}
        public String Name {get; set;}
        public String Producer {get; set;}
        public Double Price {get; set;}
    }
}