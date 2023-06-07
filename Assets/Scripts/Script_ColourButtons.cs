using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ColourButtons : MonoBehaviour
{
    [Header("Script References")]
    public Script_VehicleButtons scriptVehicleButtons;
    public Script_VehicleColourChange[] scriptColourChange;
    public Script_PriceChange scriptPriceChange;

    [Header("Colour Selection")]
    [SerializeField] public ScriptableObject[] colours;
    int colourIndex;

    public void ChosenRed()
    {
        foreach (ScriptableObject vehicleColour in colours)
        {
            if (vehicleColour.name == "Object_Red")
            {
                colourIndex = 1;
                scriptPriceChange.colourPrice = 30;
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
                scriptPriceChange.colourPrice = 40;
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
                scriptPriceChange.colourPrice = 30;
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
                scriptPriceChange.colourPrice = 20;
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
                scriptPriceChange.colourPrice = 20;
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
                        scriptColourChange[0].ChangeRed();
                        break;
                    case 2:
                        scriptColourChange[1].ChangeRed();
                        break;
                    case 3:
                        scriptColourChange[2].ChangeRed();
                        break;
                    case 4:
                        scriptColourChange[3].ChangeRed();
                        break;
                    case 5:
                        scriptColourChange[4].ChangeRed();
                        break;
                }
                break;
            case 2:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        scriptColourChange[0].ChangeYellow();
                        break;
                    case 2:
                        scriptColourChange[1].ChangeYellow();
                        break;
                    case 3:
                        scriptColourChange[2].ChangeYellow();
                        break;
                    case 4:
                        scriptColourChange[3].ChangeYellow();
                        break;
                    case 5:
                        scriptColourChange[4].ChangeYellow();
                        break;
                }
                break;
            case 3:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        scriptColourChange[0].ChangeGreen();
                        break;
                    case 2:
                        scriptColourChange[1].ChangeGreen();
                        break;
                    case 3:
                        scriptColourChange[2].ChangeGreen();
                        break;
                    case 4:
                        scriptColourChange[3].ChangeGreen();
                        break;
                    case 5:
                        scriptColourChange[4].ChangeGreen();
                        break;
                }
                break;
            case 4:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        scriptColourChange[0].ChangeBlue();
                        break;
                    case 2:
                        scriptColourChange[1].ChangeBlue();
                        break;
                    case 3:
                        scriptColourChange[2].ChangeBlue();
                        break;
                    case 4:
                        scriptColourChange[3].ChangeBlue();
                        break;
                    case 5:
                        scriptColourChange[4].ChangeBlue();
                        break;
                }
                break;
            case 5:
                switch (scriptVehicleButtons.vehicleIndex)
                {
                    case 1:
                        scriptColourChange[0].ChangeBlack();
                        break;
                    case 2:
                        scriptColourChange[1].ChangeBlack();
                        break;
                    case 3:
                        scriptColourChange[2].ChangeBlack();
                        break;
                    case 4:
                        scriptColourChange[3].ChangeBlack();
                        break;
                    case 5:
                        scriptColourChange[4].ChangeBlack();
                        break;
                }
                break;
        }
    }
}
