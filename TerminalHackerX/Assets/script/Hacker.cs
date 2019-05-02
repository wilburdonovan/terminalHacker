using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    int level;

	// Use this for initialization
	void Start () {
        MainScreen();

    }

    void MainScreen ()
    {
        Terminal.WriteLine("You have hacked BPC");
        Terminal.WriteLine("Press 1 for English");
        Terminal.WriteLine("Press 2 for Maths");
        Terminal.WriteLine("Press 3 for IT");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput (string input)
    {
        Terminal.ClearScreen();
        print(input);

        if (input == "menu")
        {
            MainScreen();
        } else if (input == "1")
        {
            level = 1;
            Terminal.WriteLine("you hackedd English");
        } else if (input == "2")
        {
            level = 2;
            Terminal.WriteLine("you hackedd Maths");
        } else if (input == "3")
        {
            level = 3;
        } else
        {
            Terminal.WriteLine("invalid input.");
            MainScreen();
        }
    }

}
