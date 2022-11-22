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
 *   - Setters/getters: Setters for name & serProblem format with .ToTitleCase()
 *  FormDrones Class: 
 *   Queue<Drone> RegularService: Global queue to repair (default cost).
 *   Queue<Drone> ExpressService: Global queue to repair (cost +15% extra).
 *   List<Drone> FinishedList: Global List of completed repair work 
 *     (remove from list when collected). 
 *   - Once drone repaired dequeue it & add to FinishedList.
 *   - Charge client on collection then remove from FinishedList.
 *   AddNewItem(): Adds new service item to a Queue<>.
 *   GetServicePriority(): Returns value of Radio for Queue Priority.
 *    - MUST be called in AddNewItem() before adding to queue.
 *   tbSerCost_KeyPress(): Only accept double value with 1 decimal point.
 *   IncrementTag(): Increments the service tag control.
 *    - NOT data but CONTROL as its for the next input (I think).
 *    - MUST be called in AddNewItem() before adding to queue.
 *   listView(reg/exp)_MouseClick(): Display Name & Problem in related TextBoxes. (maybe pass ref)
 *   btnRemove(Reg/Exp)_Click(): Dequeue oldest then add it to FinishedList 
 *     & update displays for both queue & finished.
 *   listFinished_DoubleClick(): Delete selected item in ListBox & FinishedList.
 *   ClearFields(): Clears all the TextBoxes after every new item added.
 *  - Full error trapping & feedback messages in status strip (general 
 *      or critical feedback NOT required).
 * Form Design:
 *  - ListView Regualar: Display items in Regualar queue with all attributes.
 *  - ListView Express: Display items in Express queue with all attributes.
 *  - ListBox Finished: Completed repairs to be collected display Name & Cost.
 *  - 4 TextBoxes: Client Name, Drone Model, Service Cost & Service Problem.
 *  - 3 Buttons: 2 dequeue/remove btns & add.
 *  - Service Tag: Control= NumericUpDown, Min= 100, Max=900 & Increment= 10.
 *  - Queue Priority: Control= GroupBox(2 Radio btns) (NOT class field).
 *  - Service Problem: Control= multi-lined TextBox.
 *  - StatusStrip: Full error trapping & feedback messages in status strip 
 *      (general or critical feedback NOT required).
 * IMPORTANT NOTES: 
 *  - Can't dequeue or peek an empty queue (maybe use break; in for loop).
 *  - Demonstrate use of in-built functions (ie. Use built-in whenever possible 
 *      to minimise my code).
 *  - Queues: Only adds elements to end of queue & removes from front.
 */
namespace AT3_DroneQueues
{
    public partial class FormDrone : Form
    {
        Queue<Drone> RegularServic = new Queue<Drone>();
        Queue<Drone> ExpressService = new Queue<Drone>();
        List<Drone> FinishedList = new List<Drone>();
        public FormDrone()
        {
            InitializeComponent();
        }

        // btn to add a new valid record to a queue & display it
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {

        }

        // btn to dequeue regular, add it to FinishedList & update displays
        private void btnRemoveReg_Click(object sender, EventArgs e)
        {

        }

        // btn to dequeue express, add it to FinishedList & update displays
        private void btnRemoveExp_Click(object sender, EventArgs e)
        {

        }

        // Display Name & Problem in related TextBoxes. (maybe pass ref)
        private void listViewRegular_MouseClick(object sender, MouseEventArgs e)
        {

        }

        // Display Name & Problem in related TextBoxes. (maybe pass ref)
        private void listViewExpress_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listFinished_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
