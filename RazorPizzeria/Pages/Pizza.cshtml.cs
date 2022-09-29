using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Magerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 5
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Ham = true,
                Pineapple = true,
                FinalPrice = 6
            }
        };
        public void OnGet()
        {
        }
    }
}
