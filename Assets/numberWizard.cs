using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour
{
    // declare variable and initialize
    int max = 1000;
    int min = 0;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // This is a function, def as a "contract", it is a recipe
    // void = return nothing
    // function name should describe "What to do"
    // () = nothing
    void StartGame() 
    {
        // print("Welcome to number wizard!");
        // Debug.Log gives more flexibility and control
        // Encapsulating: moving code into a function (aka "Blackbox")
        Debug.Log("Welcome to number wizard, home of Harry Pothead!");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or greater than " + guess);
        Debug.Log("Push up = higher, Push down = lower, Push enter = number found");
        Debug.Log("Press space to print current guessed number.");

        // edge case, cannot reach 1000, will stop at max-1 OR 999
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        {
            // if (Input.GetKeyDown(KeyCode.Space))
            // {
            //     Debug.Log("Current guess is at: " + guess);
            // }
            
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = guess;
                NextGuess();
                // Debug.Log("Guess is: " + guess);
                // Debug.Log("New min is: " + min);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = guess;
                NextGuess();
                // Debug.Log("Guess is: " + guess);
                // Debug.Log("New max is: " + max);
            }

            else if (Input.GetKeyDown(KeyCode.Return)) 
            {
                print("Your number was found!  It is: " + guess);
            }
        }
    }

    void NextGuess() 
    {
        // refactor the if statements
        guess = (max + min) / 2;
        Debug.Log("Is it higher or greater than: " + guess);
    }
}
