using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace House
{
    public partial class Form1 : Form
    {
        private Location currentLocation;

        OutsideWithHidingPlace garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace driveway;


        RoomWithHidingPlace diningRoom;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        int Moves;

        Opponent opponent;

        public Form1()
        {
            
            
            InitializeComponent();
            CreateObject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CreateObject()
        {
 

            garden = new OutsideWithHidingPlace("Garden", false,"inside the shed");
            frontYard = new OutsideWithDoor("FrontYard", false, "an heavy-looking oak door");
            backYard = new OutsideWithDoor("BackYard", true, "a screen door");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");
           
            diningRoom = new RoomWithHidingPlace("DiningRoom", "a crystal chandelier","in the tall armoire");
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet","inside the closet", "an oak door with a brass knob");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "in the cabinet","a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom=new RoomWithHidingPlace("MasterBedroom","a large bed","under the bed");
            secondBedroom=new RoomWithHidingPlace("Second Bedroom","a small bed","under the bed");


            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] {  garden, backYard ,driveway};
            backYard.Exits = new Location[] { garden, frontYard ,driveway};
            driveway.Exits = new Location[] { backYard, frontYard };
            
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] {  diningRoom,stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            opponent = new Opponent(frontYard);

            checkButton.Visible = false;
            goHereButton.Visible = false;
            exits.Visible = false;
            goThroughTheDoorButton.Visible = false;

            Moves = 0;

        }

        private void MoveToANewLocation(Location destination)
        {
            currentLocation=destination;
            Moves += 1;
            RedrawForm();


        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor currentLocationHasDoor=currentLocation as IHasExteriorDoor;
            MoveToANewLocation(currentLocationHasDoor.DoorLocation);
        }

        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(move #" + Moves + ")" ;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoorButton.Visible = true;
            else
                goThroughTheDoorButton.Visible = false;
            if (currentLocation is IHidingPlace)
            {
                checkButton.Visible = true;
                IHidingPlace HidePlace = currentLocation as IHidingPlace;
                checkButton.Text = "Check " + HidePlace.HidingPlaceName;
            }

            else
                checkButton.Visible = false;
        }

        private void ResetGame()
        { 
            MessageBox.Show("You found me in "+Moves.ToString()+" moves!");
            IHidingPlace HidePlace=currentLocation as IHidingPlace;
            description.Text = "You found your opponent " + HidePlace.HidingPlaceName + " in " + Moves.ToString() + " moves!";

            Moves = 0;
            exits.Visible = false;
            goHereButton.Visible = false;
            goThroughTheDoorButton.Visible = false;
            checkButton.Visible = false;
            hideButton.Visible = true;

        }

        private void checkButton_Click(object sender, EventArgs e)//没写完
        {
            if (opponent.Check(currentLocation))
                ResetGame();
            else
            {
                IHidingPlace HidePlace = currentLocation as IHidingPlace;
                description.Text = "There is nobody " + HidePlace.HidingPlaceName;
            }
               
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                description.Text = i.ToString() + "……";
                System.Threading.Thread.Sleep(200);
                opponent.Move();
                Application.DoEvents();
            }
            description.Text = "Ready or not,here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHereButton.Visible = true;
            exits.Visible = true;
            hideButton.Visible = false;
            MoveToANewLocation(livingRoom);

        }

    }
}
