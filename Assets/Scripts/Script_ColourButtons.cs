using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ColourButtons : MonoBehaviour
{
    [Header("Colour Selection")]
    [SerializeField] public ScriptableObject[] colours;
    public bool isRed;
    public bool isYellow;
    public bool isGreen;
    public bool isBlue;
    public bool isBlack;

    public void ChosenRed()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Red")
            {
                Falsify();
                isRed = true;
                Debug.Log("Object: " + vehicleColour);
                Debug.Log("Red = " + isRed);
            }
        }
    }

    public void ChosenYellow()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Yellow")
            {
                Falsify();
                isYellow = true;
                Debug.Log("Object: " + vehicleColour);
                Debug.Log("Yellow = " + isYellow);
            }
        }
    }

    public void ChosenGreen()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Green")
            {
                Falsify();
                isGreen = true;
                Debug.Log("Object: " + vehicleColour);
                Debug.Log("Green = " + isGreen);
            }
        }
    }

    public void ChosenBlue()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Blue")
            {
                Falsify();
                isBlue = true;
                Debug.Log("Object: " + vehicleColour);
                Debug.Log("Blue = " + isBlue);
            }
        }
    }

    public void ChosenBlack()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Black")
            {
                Falsify();
                isBlack = true;
                Debug.Log("Object: " + vehicleColour);
                Debug.Log("Black = " + isBlack);
            }
        }
    }

    private void Falsify()
    {
        isRed = false;
        isYellow = false;
        isGreen = false;
        isBlue = false;
        isBlack = false;
    }
}
