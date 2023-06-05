using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_VehicleButtons : MonoBehaviour
{
    [Header("VehicleSelection")]
    public Vehicles[] vehicleModel;
    VehicleColour vehicleColour;

    public void ChosenRaceCar()
    {
        foreach (var vehicle in vehicleModel)
        {

        }
    }

    /*
    [Header("Vehicle Check")]
    public bool chosenRaceCar;
    public bool chosenSedan;
    public bool chosenSUV;
    public bool chosenTractor;
    public bool chosenDelivery;

    //Would be good to put this in an array instead
    [Header("Vehicle Models")]
    public GameObject raceCar;
    public GameObject sedan;
    public GameObject SUV;
    public GameObject tractor;
    public GameObject delivery;

    private void Start()
    {
        chosenRaceCar = false;
        chosenSedan = false;
        chosenSUV = false;
        chosenTractor = false;
        chosenDelivery = false;
    }

    public void ChosenRaceCar()
    {
        SetModelActivity(raceCar);

        SetModelInactivity(sedan, chosenSedan);
        SetModelInactivity(SUV, chosenSUV);
        SetModelInactivity(tractor, chosenTractor);
        SetModelInactivity(delivery, chosenDelivery);
    }

    public void ChosenSedan()
    {
        SetModelActivity(sedan);

        SetModelInactivity(raceCar, chosenRaceCar);
        SetModelInactivity(SUV, chosenSUV);
        SetModelInactivity(tractor, chosenTractor);
        SetModelInactivity(delivery, chosenDelivery);
    }

    public void ChosenSUV()
    {
        SetModelActivity(SUV);

        SetModelInactivity(raceCar, chosenRaceCar);
        SetModelInactivity(sedan, chosenSedan);
        SetModelInactivity(tractor, chosenTractor);
        SetModelInactivity(delivery, chosenDelivery);
    }

    public void ChosenTractor()
    {
        SetModelActivity(tractor);

        SetModelInactivity(raceCar, chosenRaceCar);
        SetModelInactivity(sedan, chosenSedan);
        SetModelInactivity(SUV, chosenSUV);
        SetModelInactivity(delivery, chosenDelivery);
    }

    public void ChosenDelivery()
    {
        SetModelActivity(delivery);

        SetModelInactivity(raceCar, chosenRaceCar);
        SetModelInactivity(sedan, chosenSedan);
        SetModelInactivity(SUV, chosenSUV);
        SetModelInactivity(tractor, chosenTractor);
    }

    private void SetModelActivity(GameObject vehicleModel)
    {
        vehicleModel.SetActive(true);
    }

    private void SetModelInactivity(GameObject vehicleModel, bool vehicleChosen)
    {
        vehicleModel.SetActive(false);
        vehicleChosen = false;
    }
    */
}
