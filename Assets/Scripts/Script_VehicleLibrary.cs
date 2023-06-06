using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/VehicleModels")]

public class Script_VehicleLibrary : ScriptableObject
{
    [SerializeField] public Vehicles vehicles;

    [System.Serializable]
    public class Vehicles
    {
        [Header("Core Components")]
        public VehicleName vehicleName;
        public GameObject vehicleModel;
        public string vehiclePrice;

        [Header("Stats")]
        public float vehicleSpeed;
        public float vehicleAcceleration;
        public float vehicleHandling;
    }

    public enum VehicleName
    {
        RaceCar = 0,
        Sedan = 1,
        SUV = 2,
        Tractor = 3,
        Delivery = 4
    }
}
