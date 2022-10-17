//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Catalog catalog1 = new Catalog();
            catalog1.AddProductToCatalog("Café", 100);
            catalog1.AddProductToCatalog("Leche", 200);
            catalog1.AddProductToCatalog("Café con leche", 300);
            catalog1.AddEquipmentToCatalog("Cafetera", 1000);
            catalog1.AddEquipmentToCatalog("Hervidor", 2000);

            Recipe recipe = new Recipe();
            recipe.FinalProduct = catalog1.GetProduct("Café con leche");
            recipe.AddStep(new Step(catalog1.GetProduct("Café"), 100, catalog1.GetEquipment("Cafetera"), 120));
            recipe.AddStep(new Step(catalog1.GetProduct("Leche"), 200, catalog1.GetEquipment("Hervidor"), 60));

            IPrinter printer;
            printer = new ConsolePrinter();
            printer.PrintRecipe(recipe);
            printer = new FilePrinter();
            printer.PrintRecipe(recipe);
        }
    }
}

        
