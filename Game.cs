﻿using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        internal static int healthPoints = 3;
        
        
        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal static void LoseHealth()
        {
            healthPoints--;
            if (healthPoints > 0)
            {
                Console.WriteLine(healthPoints + "PV restant");
            }
            else
            {
                Console.WriteLine("Tu es mort!");
                Finish();
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }


    }
}
