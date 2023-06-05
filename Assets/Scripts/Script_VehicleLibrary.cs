using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/VehicleModels")]

public class Script_VehicleLibrary : ScriptableObject
{
    [SerializeField] public Vehicles[] vehicleModel;
}

public enum VehicleColour
{
    Red = 0,
    Yellow = 1,
    Green = 2,
    Blue = 3,
    Black = 4
}

[System.Serializable]
public class Vehicles
{
    public GameObject vehicleModel;
}
