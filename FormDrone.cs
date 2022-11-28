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

        // btn to add a new valid item to a queue & display it
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            int wasAddedQ = AddNewItem();
            if (wasAddedQ != -1)
            {
                ClearFields();
                DisplayQueues(wasAddedQ);
            }
        }

        //______________________NOT STARTED_________________________
        // btn to dequeue regular, add it to FinishedList & update displays
        private void btnRemoveReg_Click(object sender, EventArgs e)
        {

        }

        //______________________NOT STARTED_________________________
        // btn to dequeue express, add it to FinishedList & update displays
        private void btnRemoveExp_Click(object sender, EventArgs e)
        {

        }

        // Output selected Regular item's Name & Problem to their TextBoxes
        private void listViewRegular_MouseClick(object sender, MouseEventArgs e)
        {
            SelectItems(ref RegularService, ref listViewRegular);
        }

        // Output selected Express item's Name & Problem to their TextBoxes
        private void listViewExpress_MouseClick(object sender, MouseEventArgs e)
        {
            SelectItems(ref ExpressService, ref listViewExpress);
        }

        //______________________NOT STARTED_________________________
        // Delete selected item in ListBox & from FinishedList
        private void listFinished_DoubleClick(object sender, EventArgs e)
        {

        }

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

        // Displays queue in its ListView (Reg= 1, Exp= 2)
        private void DisplayQueues(int choice)
        {
            ref ListView myListView = ref listViewRegular;
            ref Queue<Drone> myQueue = ref RegularService;
            if (choice == 2)
            {
                myListView = ref listViewExpress;
                myQueue = ref ExpressService;
            }

            // Clear the list
            myListView.Items.Clear();
            // Displays all items in listViewItems
            foreach (Drone d in myQueue)
            {
                ListViewItem lvItems =
                    new ListViewItem(d.gsClientName);
                lvItems.SubItems.Add(d.gsModel);
                lvItems.SubItems.Add(d.gsSerCost.ToString());
                lvItems.SubItems.Add(d.gsSerTag.ToString());
                lvItems.SubItems.Add(d.gsSerProblem);
                myListView.Items.Add(lvItems);
            }
        }

        //______________________NOT STARTED_________________________
        // Displays FinishedList in ListBox (name & cost only)
        private void DisplayFinished()
        {

        }

        // Adds new service item to a Queue<>
        private int AddNewItem()
        {
            //MUST call GetServicePriority() & IncrementTag() before adding to queue
            int wasAddedQ = -1;
            string statMsg = "";
            // validData = false if invalid field & DONT add item (stat-msg)
            bool validData = true;
            int serviceTag = -1;
            double newPrice = -1.0;
            string missingField = "";

            resetColors();
            if (String.IsNullOrEmpty(tbName.Text))
            {
                validData = false;
                missingField = "Name, ";
                tbName.BackColor = Color.LightCoral;
            }
            if (String.IsNullOrEmpty(tbModel.Text))
            {
                validData = false;
                missingField += "Model, ";
                tbModel.BackColor = Color.LightCoral;
            }
            if (String.IsNullOrEmpty(tbProblem.Text))
            {
                validData = false;
                missingField += "Definition, ";
                tbProblem.BackColor = Color.LightCoral;
            }
            if (String.IsNullOrEmpty(tbCost.Text))
            {
                validData = false;
                missingField += "Cost, ";
                tbCost.BackColor = Color.LightCoral;
            } 
            else
            {
                // Try to take input price as double
                try
                {
                    newPrice = Convert.ToDouble(tbCost.Text);
                }
                catch
                // If price can't be convert to double set validData to false
                {
                    validData = false;
                    missingField += "Cost, ";
                    tbCost.BackColor = Color.LightCoral;
                }
            }
            string priority = GetServicePriority();
            if (String.IsNullOrEmpty(priority))
            {
                validData = false;
                missingField += "Queue Priority, ";
                grpPriority.BackColor = Color.LightCoral;
            }
            // To prevent incrementing without adding items
            if (validData == true)
            {
                serviceTag = IncrementTag();
                if (serviceTag < numUpDownTag.Minimum)
                {
                    validData = false;
                    missingField += "Tag, ";
                    numUpDownTag.BackColor = Color.LightCoral;
                }
            }
            if (validData == false)
            {
                statMsg += "ERROR Invalid Input: Item will NOT be added to queue."
                    + "\nReason: The following field(s) are empty/invalid: "
                    + missingField.Remove(missingField.Length - 2);
            }
            else // Add valid item to a queue
            {
                Drone newDrone = new Drone();
                newDrone.gsClientName = tbName.Text;
                newDrone.gsModel = tbModel.Text;
                newDrone.gsSerProblem = tbProblem.Text;
                newDrone.gsSerCost = newPrice;
                newDrone.gsSerTag = serviceTag;
                if (priority == "Regular")
                {
                    RegularService.Enqueue(newDrone);
                    wasAddedQ = 1;
                }
                else
                {
                    ExpressService.Enqueue(newDrone);
                    wasAddedQ = 2;
                }
                statMsg += "Item for the client \"" + tbName.Text
                    + "\" was added to the " + priority + " Queue.)";
            }
            // Display message in status strip & true to word wrap
            StatusMsg(statMsg, true);
            return wasAddedQ;
        }

        // Returns value of Radio for Queue Priority
        private string GetServicePriority()
        {
            //MUST be called in AddNewItem() before adding to queue
            string priority = null;
            foreach (RadioButton r in grpPriority.Controls)
            {
                if (r.Checked)
                {
                    priority = r.Text;
                }
            }
            return priority;
        }

        // Increments the tag control (& data but im not sure)
        // ONLY CALL AFTER all other fields are confirmed valid
        private int IncrementTag()
        {
            //MUST be called in AddNewItem() before adding to queue
            //(MAYBE) Not the data but the control as its for the next input
            int inTag = -1;
            try // Try to take input tag as an int
            {
                inTag = Convert.ToInt32(numUpDownTag.Value);
                if (inTag == 900)
                {
                    MessageBox.Show("ERROR CANNOT Add Item: Already at max value" 
                        + " for Service Tag\nReason: Maximum tag value is 900, "
                        + "lower service tag to add a new item");
                    inTag = -2;
                }
                numUpDownTag.UpButton();
            }
            catch // If tag can't be convert to int set inTag to -1
            {
                inTag = -1;
                numUpDownTag.Value = numUpDownTag.Minimum;
            }
            return inTag;
        }

        // Outputs the name & problem of the item selected in the listview to
        //   their textboxes. Bolds only the selected item.
        private void SelectItems(ref Queue<Drone> myQueue, ref ListView myListView)
        {
            // Unbolds all items first so only selected item is bold
            Font notSelectedFont = new Font(myListView.Font, FontStyle.Regular);
            for (int i = 0; i < RegularService.Count; i++)
            {
                listViewRegular.Items[i].Font = notSelectedFont;
            }
            for (int i = 0; i < ExpressService.Count; i++)
            {
                listViewExpress.Items[i].Font = notSelectedFont;
            }
            // If it detects an item is selected make its name bold
            if (myListView.SelectedIndices.Count != 0)
            {
                int selectedIndex = myListView.SelectedIndices[0];
                myListView.Items[selectedIndex].Font =
                    new Font(myListView.Font, FontStyle.Bold);
                tbName.Text = myQueue.ElementAt(selectedIndex).gsClientName;
                tbProblem.Text = myQueue.ElementAt(selectedIndex).gsSerProblem;
            }
        }

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
            resetColors();
        }

        // Set all the fields background colors back to default
        private void resetColors()
        {
            tbName.BackColor = SystemColors.Window;
            tbModel.BackColor = SystemColors.Window;
            tbCost.BackColor = SystemColors.Window;
            tbProblem.BackColor = SystemColors.Window;
            numUpDownTag.BackColor = SystemColors.Window;
            grpPriority.BackColor = SystemColors.Control;
        }

        //######################BASIC_COMPLETE############################
        // Displays the status message after formating msg & strip
        private void StatusMsg(string statMsg, bool wrapTxt)
        {
            int originalHeight = statusStrip1.Height;
            // Strip text line NOT visible if >95 char for default size
            int maxLength = (int)(Convert.ToDouble(statStripLabel.Width) / 4.8) - 3;
            statMsg = statMsg.Trim('\n');
            // Manual word wrap for the status strip
            if (wrapTxt == true)
            {
                string[] newLines = statMsg.Split('\n');
                string msgParts = "";
                foreach (var line in newLines)
                {
                    string[] words = line.Split(' ');
                    var parts = new Dictionary<int, string>();
                    string part = string.Empty;
                    int partCounter = 0;
                    foreach (var word in words)
                    {
                        if (part.Length + word.Length < maxLength)
                            part += string.IsNullOrEmpty(part) ? word : " " + word;
                        else
                        {
                            parts.Add(partCounter, part);
                            part = word;
                            partCounter++;
                        }
                    }
                    parts.Add(partCounter, part);
                    foreach (var item in parts)
                        msgParts += item.Value + "\n";
                }
                statMsg = msgParts.Trim('\n');
            }
            statStripLabel.Text = statMsg;
        }
    }
}
