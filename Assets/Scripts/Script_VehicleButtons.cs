using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_VehicleButtons : MonoBehaviour
{
    [Header("VehicleSelection")]
    [SerializeField] public ScriptableObject[] vehicles;
    public bool isRaceCar;
    public bool isSedan;
    public bool isSUV;
    public bool isTractor;
    public bool isDelivery;

    public void ChosenRaceCar()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_RaceCar")
            {
                Falsify();
                isRaceCar = true;
                Debug.Log("Object: " + vehicleObject);
                Debug.Log("Race Car = " + isRaceCar);
            }
        }
    }

    public void ChosenSedan()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Sedan")
            {
                Falsify();
                isSedan = true;
                Debug.Log("Object: " + vehicleObject);
                Debug.Log("Sedan = " + isSedan);
            }
        }
    }

    public void ChosenSUV()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_SUV")
            {
                Falsify();
                isSUV = true;
                Debug.Log("Object: " + vehicleObject);
                Debug.Log("SUV = " + isSUV);
            }
        }
    }

    public void ChosenTractor()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Tractor")
            {
                Falsify();
                isTractor = true;
                Debug.Log("Object: " + vehicleObject);
                Debug.Log("Tractor = " + isTractor);
            }
        }
    }

    public void ChosenDelivery()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Delivery")
            {
                Falsify();
                isDelivery = true;
                Debug.Log("Object: " + vehicleObject);
                Debug.Log("Delivery = " + isDelivery);
            }
        }
    }

    private void Falsify()
    {
        isRaceCar = false;
        isSedan = false;
        isSUV = false;
        isTractor = false;
        isDelivery = false;
}
}
