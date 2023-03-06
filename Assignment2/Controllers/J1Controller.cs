using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
        public string Menu(int burger, int drink, int dessert, int side)
    {
        int totalCalories = 0;

        totalCalories += GetBurgerCalories(burger);
        totalCalories += GetDrinkCalories(drink);
        totalCalories += GetsideCalories(side);
        totalCalories += GetDessertCalories(dessert);

        return $"Your total calorie count is {totalCalories}";
    }
}
