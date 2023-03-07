using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
        public string Menu(int burger, int drink, int dessert, int side)
    {
        int totalCalories = 0;

        totalCalories += GetBurgerCalories(burger);
        totalCalories += GetDrinkCalories(drink);
        totalCalories += GetSideCalories(side);
        totalCalories += GetDessertCalories(dessert);

        return $"Your total calorie count is {totalCalories}";
    }

    private int GetBurgerCalories(int burger)
    {
        if (burger == 1)
            return 461;
        else if (burger == 2)
            return 431;
        else if (burger == 3)
            return 420;
        else
            return 0;
    }

    private int GetDrinkCalories(int drink)
    {
        if (drink == 1)
            return 130;
        else if (drink == 2)
            return 160;
        else if (drink == 3)
            return 118;
        else
            return 0;
    }

    private int GetSideCalories(int side)
    {
        if (side == 1)
            return 100;
        else if (side == 2)
            return 57;
        else if (side == 3)
            return 70;
        else
            return 0;
    }

    private int GetDessertCalories(int dessert)
    {
        if (dessert == 1) //Apple Pie
            return 167;
        else if (dessert == 2)
            return 266;
        else if (dessert == 3)
            return 75;
        else
            return 0;
    }

