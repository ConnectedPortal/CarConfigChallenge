using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/VehicleColours")]

public class Script_VehicleColourLibrary : ScriptableObject
{
    [SerializeField] public Colour colour;

    [System.Serializable]
    public class Colour
    {
        [Header("Customisation")]
        public VehicleColour vehicleColour;
        public Material vehicleMaterial;
        public string colourPrice;
    }

    public enum VehicleColour
    {
        Red = 0,
        Yellow = 1,
        Green = 2,
        Blue = 3,
        Black = 4
    }
}