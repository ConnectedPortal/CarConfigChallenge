using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_VehicleButtons : MonoBehaviour
{
    [Header("VehicleSelection")]
    [SerializeField] public ScriptableObject[] vehicles;
    public int vehicleIndex;

    //Models are already inside ScriptableObjects
    //Need to find out a way to get them from objects to instantiate them in scene
    [Header("Vehicle Models")]
    public GameObject modelRaceCar;
    public GameObject modelSedan;
    public GameObject modelSUV;
    public GameObject modelTractor;
    public GameObject modelDelivery;

    public void ChosenRaceCar()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_RaceCar")
            {
                vehicleIndex = 1;
                ActivateModels();
            }
        }
    }

    public void ChosenSedan()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Sedan")
            {
                vehicleIndex = 2;
                ActivateModels();
            }
        }
    }

    public void ChosenSUV()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_SUV")
            {
                vehicleIndex = 3;
                ActivateModels();
            }
        }
    }

    public void ChosenTractor()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Tractor")
            {
                vehicleIndex = 4;
                ActivateModels();
            }
        }
    }

    public void ChosenDelivery()
    {
        foreach (ScriptableObject vehicleObject in vehicles)
        {
            if (vehicleObject.name == "Object_Delivery")
            {
                vehicleIndex = 5;
                ActivateModels();
            }
        }
    }

    private void ActivateModels()
    {
        switch (vehicleIndex)
        {
            case 1:
                modelRaceCar.SetActive(true);

                modelSedan.SetActive(false);
                modelSUV.SetActive(false);
                modelTractor.SetActive(false);
                modelDelivery.SetActive(false);
                break;
            case 2:
                modelSedan.SetActive(true);

                modelRaceCar.SetActive(false);
                modelSUV.SetActive(false);
                modelTractor.SetActive(false);
                modelDelivery.SetActive(false);
                break;
            case 3:
                modelSUV.SetActive(true);

                modelRaceCar.SetActive(false);
                modelSedan.SetActive(false);
                modelTractor.SetActive(false);
                modelDelivery.SetActive(false);
                break;
            case 4:
                modelTractor.SetActive(true);

                modelRaceCar.SetActive(false);
                modelSedan.SetActive(false);
                modelSUV.SetActive(false);
                modelDelivery.SetActive(false);
                break;
            case 5:
                modelDelivery.SetActive(true);

                modelRaceCar.SetActive(false);
                modelSedan.SetActive(false);
                modelSUV.SetActive(false);
                modelTractor.SetActive(false);
                break;
        }
    }
}
