using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Script_PriceChange : MonoBehaviour
{
    [Header("Values")]
    public float vechiclePrice;
    public float colourPrice;
    [SerializeField] private float totalPrice;

    [Header("UI")]
    public TMP_Text priceNumber;

    public void Start()
    {
        totalPrice = vechiclePrice + colourPrice;
        priceNumber.text = "£" + totalPrice;
    }
}
