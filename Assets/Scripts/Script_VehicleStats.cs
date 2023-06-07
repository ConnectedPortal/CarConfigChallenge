using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_VehicleStats : MonoBehaviour
{
    [Header("Slider UI")]
    public Slider sliderSpeed;
    public Slider sliderAcceleration;
    public Slider sliderHandling;

    void Start()
    {
        sliderSpeed.maxValue = 10f;
        sliderAcceleration.maxValue = 10f;
        sliderHandling.maxValue = 10f;
    }

    public void VehicleStatChange(float speed, float acceleration, float handling)
    {
        sliderSpeed.value = speed;
        sliderAcceleration.value = acceleration;
        sliderHandling.value = handling;
    }
}
