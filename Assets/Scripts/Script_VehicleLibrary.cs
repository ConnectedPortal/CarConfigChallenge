using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_VehicleLibrary : MonoBehaviour
{
    [Header("Vehicle Check")]
    public bool chosenRaceCar;
    public bool chosenSedan;
    public bool chosenSUV;
    public bool chosenTractor;
    public bool chosenDelivery;

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

    //need a better way to check than every frame
    //maybe look into unity events?
    //there was a yandere dev code fix video that had something helpful
    //will need to change this for button choices anyway
    private void Update()
    {
        if (chosenRaceCar)
        {
            SetModelActivity(raceCar);

            SetModelInactivity(sedan, chosenSedan);
            SetModelInactivity(SUV, chosenSUV);
            SetModelInactivity(tractor, chosenTractor);
            SetModelInactivity(delivery, chosenDelivery);
        }
        else if (chosenSedan)
        {
            SetModelActivity(sedan);

            SetModelInactivity(raceCar, chosenRaceCar);
            SetModelInactivity(SUV, chosenSUV);
            SetModelInactivity(tractor, chosenTractor);
            SetModelInactivity(delivery, chosenDelivery);
        }
        else if (chosenSUV)
        {
            SetModelActivity(SUV);

            SetModelInactivity(sedan, chosenSedan);
            SetModelInactivity(raceCar, chosenRaceCar);
            SetModelInactivity(tractor, chosenTractor);
            SetModelInactivity(delivery, chosenDelivery);
        }
        else if (chosenTractor)
        {
            SetModelActivity(tractor);

            SetModelInactivity(sedan, chosenSedan);
            SetModelInactivity(raceCar, chosenRaceCar);
            SetModelInactivity(SUV, chosenSUV);
            SetModelInactivity(delivery, chosenDelivery);
        }
        else if (chosenDelivery)
        {
            SetModelActivity(delivery);

            SetModelInactivity(sedan, chosenSedan);
            SetModelInactivity(raceCar, chosenRaceCar);
            SetModelInactivity(SUV, chosenSUV);
            SetModelInactivity(tractor, chosenTractor);
        }
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
}
