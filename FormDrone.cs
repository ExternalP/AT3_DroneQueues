using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
/* Basic Code Structure:
 *  - 2 Classes: FormDrones.cs & Drone.cs (Drone is a simple class).
 ** Drone Class: 5 fields for Client Name, Drone Model, Service Problem, 
 *    Service Cost & Service Tag (Queue priority NOT class field).
 *   - Private Fields: clientName(string), model(string), serProblem(string), 
 *       serCost(double) & serTag(int).
 *   - Setters/getters: Setters for name & serProblem format with .ToTitleCase()
 ** FormDrones Class: 
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
 *   IncrementTag(): Increments the service tag control (& data but im not sure).
 *    - (MAYBE) Not the data but the control as its for the next input.
 *    - MUST be called in AddNewItem() before adding to queue.
 *   listView(reg/exp)_MouseClick(): Display Name & Problem in related TextBoxes.
 *    - Might be able to pass ref for queue instead of code for each queue.
 *   btnRemove(Reg/Exp)_Click(): Dequeue oldest then add it to FinishedList 
 *     & update displays for both queue & finished.
 *   listFinished_DoubleClick(): Delete selected item in ListBox & FinishedList.
 *   ClearFields(): Clears all the TextBoxes after every new item added.
 *   DisplayQueues(): Displays queue in its ListView (send queue choice).
 *   DisplayFinished(): Displays FinishedList in ListBox.
 *  - Full error trapping & feedback messages in status strip (general 
 *      or critical feedback NOT required). */
/* Form Design:
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
 **IMPORTANT NOTES: 
 *  - Can't dequeue or peek an empty queue (maybe use break; in for loop).
 *  - Demonstrate use of in-built functions (ie. Use built-in whenever possible 
 *      to minimise my code).
 *  - Queues only adds elements to end of queue & removes from front.
 */
namespace AT3_DroneQueues
{
    public partial class FormDrone : Form
    {
        // To repair queue (default cost) dequeue repaired & add to FinishedList
        Queue<Drone> RegularService = new Queue<Drone>();
        // Express repair queue (cost +15%) dequeue repaired & add to FinishedList
        Queue<Drone> ExpressService = new Queue<Drone>();
        // List of completed repair work (remove from list when collected)
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
            //Might be able to pass ref for queue instead of code for each
        }

        // Display Name & Problem in related TextBoxes. (maybe pass ref)
        private void listViewExpress_MouseClick(object sender, MouseEventArgs e)
        {
            //Might be able to pass ref for queue instead of code for each

        }

        // Delete selected item in ListBox & from FinishedList
        private void listFinished_DoubleClick(object sender, EventArgs e)
        {

        }

        //######################BASIC_COMPLETE############################
        // Only accept double value with 1 decimal point. (probally 1 dec place)
        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // only allow one decimal point 
            if (Regex.IsMatch(tbCost.Text, @"\.\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        // Displays queue in its ListView (Reg= 1, Exp= 2, Both= *)
        private void DisplayQueues(int choice)
        {

        }

        // Displays FinishedList in ListBox (name & cost only)
        private void DisplayFinished()
        {

        }

        //______________________WORKING_ON__________________________
        // Adds new service item to a Queue<>
        private void AddNewItem()
        {
            //MUST call GetServicePriority() & IncrementTag() before adding to queue

            bool wasAdded = false;
            string statMsg = "ERROR CANNOT Add Record: ERROR_MESSAGE_HERE"
                + "\nReason: SOME_REASON " + wasAdded + " SOME_REASON.";
            // Check if space in array
            if (true)
            {
                statMsg = "";
                // hasData = false if invalid field (stat-msg but still add record)
                // hasName: if false DONT add record
                bool hasName = true, hasData = true;
                int duplicateFound;
                string missingField = "";
                // Try to take input price as double
                try
                {
                    newGame.gamePrice = Convert.ToDouble(tbCost.Text);
                }
                catch
                // If price can't be convert to double set hasData to false
                {
                    MessageBox.Show("Please enter price");
                    hasData = false;
                }

                if (String.IsNullOrEmpty(tbName.Text))
                {
                    hasName = false;
                }
                if (String.IsNullOrEmpty(tbModel.Text))
                {
                    hasData = false;
                    missingField = "Category, ";
                }
                else
                if (String.IsNullOrEmpty(tbCost.Text))
                {
                    hasData = false;
                    missingField += "Structure, ";
                }
                if (String.IsNullOrEmpty(tbDefinition.Text))
                {
                    hasData = false;
                    missingField += "Definition, ";
                }

                duplicateFound = SearchRecords(tbName.Text);
                if (hasName == false)
                {
                    tbName.Focus();
                    tbName.SelectAll();
                    statMsg += "ERROR Invalid Input: Record was NOT added"
                        + "\nReason: Name field CANNOT be empty";
                }
                else if (duplicateFound != -1)
                {
                    tbName.Focus();
                    tbName.SelectAll();
                    statMsg += "ERROR Invalid Input: Record was NOT added"
                        + "\nReason: Duplicate names are NOT ALLOWED "
                        + "\nA record with the name: \"" + tbName.Text
                        + "\" already exists at index " + duplicateFound;
                }

                // Add record to myRecordsArray[] if valid
                if (hasName == true && duplicateFound == -1)
                {
                    myRecordsArray[nullIndex, 0] = tbName.Text;
                    myRecordsArray[nullIndex, 1] = tbCategory.Text;
                    myRecordsArray[nullIndex, 2] = tbStructure.Text;
                    myRecordsArray[nullIndex, 3] = tbDefinition.Text;

                    wasAdded = true;
                    statMsg += "Record called \"" + myRecordsArray[nullIndex, 0]
                        + "\" was added (" + (nullIndex + 1) + "/" + maxRecords + " records)";
                    nullIndex++;
                    BubbleSort();
                    if (hasData == false)
                    {
                        statMsg += "\nThe following field(s) are empty: "
                            + missingField.Remove(missingField.Length - 2)
                            + "\nRemember to fill them in later\n";
                    }
                }
            }
        }

        // Returns value of Radio for Queue Priority
        private void GetServicePriority()
        {
            //MUST be called in AddNewItem() before adding to queue

        }

        // Increments the tag control (& data but im not sure)
        private void IncrementTag()
        {
            //MUST be called in AddNewItem() before adding to queue
            //(MAYBE) Not the data but the control as its for the next input

        }

        //######################BASIC_COMPLETE############################
        // Clears all the TextBoxes & radioBtns after every new item added
        private void ClearFields()
        {
            tbName.Clear();
            tbModel.Clear();
            tbCost.Clear();
            tbProblem.Clear();
            foreach (RadioButton r in grpPriority.Controls)
            {
                r.Checked = false;
            }
        }
    }
}
