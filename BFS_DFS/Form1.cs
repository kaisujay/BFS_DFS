using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFS_DFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBFS_Click(object sender, EventArgs e)
        {
            string StartingPoint = "A";
            List<string> Visited = new List<string>();

            Queue queue = new Queue();
            queue.Enqueue(StartingPoint);       // Add the starting point to QUEUE first
            Visited.Add(queue.Peek().ToString()); // OR Visited.Add(StartingPoint); Also add to VISITED list

            string[] Airports = { "A", "B", "C", "D", "E", "F", "G", "H" };
            //string[] Flights = { "A,B", "A,H", "B,C", "H,E","C,D", "E,G" };
            string[] Flights = { "A,B", "A,H", "B,C" };
            //string[] Flights = { "A,B", "A,H", "B,C", "H,E", "E,C", "C,D", "E,G" };
            //string[] Flights = { "A,B", "A,C", "B,D", "B,E", "C,E", "D,E", "D,F", "E,F" };

            while (queue.Count > 0)     // Need to run untill QUEUE is empty
            {
                for (int i = 0; i < Flights.Length; i++)        //One FOR loop will give only output - "A B H"
                {
                    if (Flights[i].Contains(queue.Peek().ToString()))   //ex : IF "A,B" contains "A" THEN split
                    {
                        string[] FlightsPoints = Flights[i].Split(',');
                        string FlightsPointsA = FlightsPoints[0];
                        string FlightsPointsB = FlightsPoints[1];

                        if (queue.Peek().ToString() == FlightsPointsA)  // IF QUEUE's 1st item is "A" THEN ...
                        {
                            if (!Visited.Contains(FlightsPointsB))      // ... Also IF "B" doesnot already existed in VISITED
                            {
                                queue.Enqueue(FlightsPointsB);      // Then add it to QUEUE
                                Visited.Add(FlightsPointsB);    // Also make it as VISITED
                            }
                        }
                        else
                        {
                            if (!Visited.Contains(FlightsPointsA))
                            {
                                queue.Enqueue(FlightsPointsA);
                                Visited.Add(FlightsPointsA);
                            }
                        }
                    }
                }
                queue.Dequeue();        // Remove from the FIRST QUEUE item
            }

            string VisitedFlights = "";
            foreach (var item in Visited)
            {
                VisitedFlights = VisitedFlights + " " + item;
            }
            MessageBox.Show(VisitedFlights);
        }

        private void buttonDFS_Click(object sender, EventArgs e)
        {
            string StartingPoint = "A";
            List<string> Visited = new List<string>();
            Stack stack = new Stack();
            stack.Push(StartingPoint);      // Add the starting point to STACK first
            Visited.Add(stack.Peek().ToString());   // OR Visited.Add(StartingPoint); Also add to VISITED list

            string[] Airports = { "A", "B", "C", "D", "E", "F", "G", "H" };
            //string[] Flights = { "A,B", "A,H", "B,C", "C,D", "E,G" };
            //string[] Flights = { "A,B", "A,H", "B,C" , "B,D" };
            string[] Flights = { "A,B", "A,H", "B,C", "H,E", "E,C", "C,D", "E,G" };
            //string[] Flights = { "A,B", "A,C", "B,D", "B,E", "C,E", "D,E", "D,F", "E,F" };

            while (stack.Count > 0)     // Need to run untill STACK is empty
            {
                for (int i = 0; i < Flights.Length; i++)    //One FOR loop will give only output - "A B C"
                {
                    if (Flights[i].Contains(stack.Peek().ToString()))   //ex : IF "A,B" contains "A" THEN split
                    {
                        string[] FlightPoints = Flights[i].Split(',');
                        string FlightPointsA = FlightPoints[0];
                        string FlightPointsB = FlightPoints[1];

                        if ((stack.Peek().ToString() == FlightPointsA))     // IF STACK's 1st item is "A" THEN ...
                        {
                            if (!Visited.Contains(FlightPointsB))       // ... Also IF "B" doesnot already existed in VISITED
                            {
                                stack.Push(FlightPointsB);      // Then add it to STACK
                                Visited.Add(FlightPointsB);     // Also make it as VISITED
                            }
                        }
                        else if ((stack.Peek().ToString() == FlightPointsB))
                        {
                            if (!Visited.Contains(FlightPointsA))
                            {
                                stack.Push(FlightPointsA);
                                Visited.Add(FlightPointsA);
                            }
                        }
                    }
                }
                stack.Pop();        // Remove from the LAST STACK item
            }
            string VisitedFlights = "";
            foreach (var item in Visited)
            {
                VisitedFlights += " " + item;
            }
            MessageBox.Show(VisitedFlights);
        }
    }
}
