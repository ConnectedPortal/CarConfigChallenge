using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Script_PriceChange : MonoBehaviour
{
    [Header("Values")]
    public int vechiclePrice;
    public int colourPrice;
    [SerializeField] private float totalPrice;

    [Header("UI")]
    public TMP_Text priceNumber;

    public void LateUpdate()
    {
        totalPrice = vechiclePrice + colourPrice;
        priceNumber.text = "£" + totalPrice;
    }
}
