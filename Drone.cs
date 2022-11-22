using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
/* Name: Corin Little
 * ID: P453208
 * Date: 22/11/2022
 * Purpose: AT3 - Drone Queues */
/* Case Study – Icarus Drone Queues
 * GUI to track drone repair in regular & express queues. Once repaired item 
 *   is dequeue & added to a finished list then deleted from list after the 
 *   client payes & picks up the repaired drone. */
/* Basic Structure:
 *  - 2 Classes: FormDrones.cs & Drone.cs (Drone is a simple class).
 *  Drone Class: 5 fields for Client Name, Drone Model, Service Problem, 
 *    Service Cost & Service Tag (Queue priority NOT class field).
 *   - Private Fields: clientName(string), model(string), serProblem(string), 
 *       serCost(double) & serTag(int).
 *   - serTag: control = NumericUpDown, Min= 100, Max=900 & Increment= 10.
 *   - Setters/getters: Setters for name & serProblem format with .ToTitleCase() */
namespace AT3_DroneQueues
{
    class Drone
    {
        // Class variables
        private string clientName;
        private string model;
        private string serProblem;
        private double serCost;
        private int serTag;
        // Variable for to title case in setters for name & problem
        private readonly static TextInfo txtInfo = new CultureInfo("en-AU", false).TextInfo;

        // Getters & setters for all variables
        public string gsClientName
        {
            get { return clientName; }
            set { clientName = txtInfo.ToTitleCase(value); }
        }

        public string gsModel
        {
            get { return model; }
            set { model = value; }
        }

        public string gsSerProblem
        {
            get { return serProblem; }
            set { serProblem = txtInfo.ToTitleCase(value); }
        }

        public double gsSerCost
        {
            get { return serCost; }
            set { serCost = value; }
        }

        public int gsSerTag
        {
            get { return serTag; }
            set { serTag = value; }
        }
    }
}
