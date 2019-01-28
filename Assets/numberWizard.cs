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
        // print("Welcome to number wizard!");
        // gives more flexibility and control
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or greater than 500");
        Debug.Log("Push up = higher, Push down = lower, Push enter = number found");

        // edge case, cannot reach 1000, will stop at max-1 OR 999
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Up arrow key was pressed");
                min = guess;
                guess = (max + min) / 2;
                Debug.Log("Guess is: " + guess);
                Debug.Log("New min is: " + min);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Down arrow key was pressed");
                max = guess;
                guess = (max + min) / 2;
                Debug.Log("Guess is: " + guess);
                Debug.Log("New max is: " + max);
            }

            else if (Input.GetKeyDown(KeyCode.Return)) 
            {
                print("Enter/Return key was pressed");
            }
        }
    }
}
