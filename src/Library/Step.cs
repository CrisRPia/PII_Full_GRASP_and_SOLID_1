//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        // Por expert, step debe saber calcular el precio total de sus
        // ingredientes.
        // Asumo que el tiempo es en segundos.
        public double EquipmentCost
        {
            // Costo equipamiento = sumatoria de tiempo de uso * costo/hora
            // del equipo para todos los pasos de la receta.
            get { return Equipment.HourlyCost * Time / 3600; }
        }

        // Por expert, step debe saber calcular el precio total del uso de su
        // equipamiento.
        public double InputCost
        {
            // Costo insumos = sumatoria de costo unitario de insumos.
            get { return Input.UnitCost * Quantity; }
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
    }
}
