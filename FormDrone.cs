using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: Corin Little
 * ID: P453208
 * Date: 22/11/2022
 * Purpose: AT3 - Drone Queues */
/* Case Study – Icarus Drone Queues
 * 
 * IMPORTANT: Demonstrate use of in-built functions (ie. Use built-in 
 *   whenever possible to minimise my code).
 * */
/* Basic Structure:
 *  - 2 classes: FormDrones.cs & Drone.cs (Drone is a simple class).
 *  - Queue<Drone> RegularService a global queue of Drone (default cost).
 *  - Queue<Drone> ExpressService a global queue of Drone (cost +15% extra).
 *  - List<Drone> FinishedList a global List of completed repair work 
 *      (remove from list when collected).
 *  - Drone has 5 fields for Client Name, Drone Model, Service Problem, 
 *      Service Cost & Service Tag.
 *  - Once drone repaired dequeue it & add to a list of completed work.
 *  - Charge client on collection & remove from completed list.
 *  - Full error trapping & feedback messages in status strip (general 
 *      or critical feedback NOT required).
 * Form Design:
 *  - 
 */
namespace AT3_DroneQueues
{
    public partial class FormDrone : Form
    {
        public FormDrone()
        {
            InitializeComponent();
        }
    }
}
