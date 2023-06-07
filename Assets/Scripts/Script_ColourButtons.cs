using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ColourButtons : MonoBehaviour
{
    [Header("Script References")]
    public Script_VehicleButtons scriptVehicleButtons;

    [Header("Colour Selection")]
    [SerializeField] public ScriptableObject[] colours;
    int colourIndex;

    [Header("Materials")]
    public Material materialRed;
    public Material materialYellow;
    public Material materialGreen;
    public Material materialBlue;
    public Material materialBlack;

    public void ChosenRed()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Red")
            {
                colourIndex = 1;
                ModelColourChange();
            }
        }
    }

    public void ChosenYellow()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Yellow")
            {
                colourIndex = 2;
                ModelColourChange();
            }
        }
    }

    public void ChosenGreen()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Green")
            {
                colourIndex = 3;
                ModelColourChange();
            }
        }
    }

    public void ChosenBlue()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Blue")
            {
                colourIndex = 4;
                ModelColourChange();
            }
        }
    }

    public void ChosenBlack()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Black")
            {
                colourIndex = 5;
                ModelColourChange();
            }
        }
    }

    private void ModelColourChange()
    {
        switch (colourIndex)
        {
            case 1:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        Debug.Log("Race Car is Red");
                        break;
                    case 2:
                        Debug.Log("Sedan is Red");
                        break;
                    case 3:
                        Debug.Log("SUV is Red");
                        break;
                    case 4:
                        Debug.Log("Tractor is Red");
                        break;
                    case 5:
                        Debug.Log("Delivery is Red");
                        break;
                }
                break;
            case 2:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        Debug.Log("Race Car is Yellow");
                        break;
                    case 2:
                        Debug.Log("Sedan is Yellow");
                        break;
                    case 3:
                        Debug.Log("SUV is Yellow");
                        break;
                    case 4:
                        Debug.Log("Tractor is Yellow");
                        break;
                    case 5:
                        Debug.Log("Delivery is Yellow");
                        break;
                }
                break;
            case 3:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        Debug.Log("Race Car is Green");
                        break;
                    case 2:
                        Debug.Log("Sedan is Green");
                        break;
                    case 3:
                        Debug.Log("SUV is Green");
                        break;
                    case 4:
                        Debug.Log("Tractor is Green");
                        break;
                    case 5:
                        Debug.Log("Delivery is Green");
                        break;
                }
                break;
            case 4:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        Debug.Log("Race Car is Blue");
                        break;
                    case 2:
                        Debug.Log("Sedan is Blue");
                        break;
                    case 3:
                        Debug.Log("SUV is Blue");
                        break;
                    case 4:
                        Debug.Log("Tractor is Blue");
                        break;
                    case 5:
                        Debug.Log("Delivery is Blue");
                        break;
                }
                break;
            case 5:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        Debug.Log("Race Car is Black");
                        break;
                    case 2:
                        Debug.Log("Sedan is Black");
                        break;
                    case 3:
                        Debug.Log("SUV is Black");
                        break;
                    case 4:
                        Debug.Log("Tractor is Black");
                        break;
                    case 5:
                        Debug.Log("Delivery is Black");
                        break;
                }
                break;
        }
    }
}
