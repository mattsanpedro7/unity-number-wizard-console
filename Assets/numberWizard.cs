using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // declare variable and initilize
        int max = 1000;
        int min = 0;

        // print("Welcome to number wizard!");
        // gives more flexibility and control
        Debug.Log("Welcome to number wizard!");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or greater than 500");
        Debug.Log("Push up = higher, Push down = lower, Push enter = number found");
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Up arrow key was pressed");
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Down arrow key was pressed");
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                print("Enter/Return key was pressed");
            }
        }
    }
}
