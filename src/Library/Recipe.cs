//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        // Por expert, le añado la responsibilidad de calcular el costo total
        // de producir un producto a la receta, pues ella conoce todos los datos
        // necesarios (ingredientes, equipamiento y tiempo para cada paso).
        public double GetProductionCost() {
            double total = 0;

            // Costo 
            foreach (Step step in steps) {
                total += step.InputCost;

                total += step.EquipmentCost;
            }
            return total;
        }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Costo total: {GetProductionCost()}");
        }
    }
}
