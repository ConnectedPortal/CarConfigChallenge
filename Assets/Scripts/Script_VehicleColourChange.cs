using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_VehicleColourChange : MonoBehaviour
{
    [Header("Script References")]
    public Script_VehicleButtons scriptvehicleButtons;

    [Header("Materials")]
    public Material[] material;
    public Material[] meshMaterials;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        meshMaterials = rend.materials;
    }

    public void ChangeRed()
    {
        switch (scriptvehicleButtons.vehicleIndex)
        {
            case 1:
                meshMaterials[0] = material[0];
                rend.materials = meshMaterials;
                break;
            case 2:
                meshMaterials[2] = material[0];
                rend.materials = meshMaterials;
                break;
            case 3:
                meshMaterials[2] = material[0];
                rend.materials = meshMaterials;
                break;
            case 4:
                meshMaterials[0] = material[0];
                rend.materials = meshMaterials;
                break;
            case 5:
                meshMaterials[1] = material[0];
                rend.materials = meshMaterials;
                break;
        }
    }

    public void ChangeYellow()
    {
        switch (scriptvehicleButtons.vehicleIndex)
        {
            case 1:
                meshMaterials[0] = material[1];
                rend.materials = meshMaterials;
                break;
            case 2:
                meshMaterials[2] = material[1];
                rend.materials = meshMaterials;
                break;
            case 3:
                meshMaterials[2] = material[1];
                rend.materials = meshMaterials;
                break;
            case 4:
                meshMaterials[0] = material[1];
                rend.materials = meshMaterials;
                break;
            case 5:
                meshMaterials[1] = material[1];
                rend.materials = meshMaterials;
                break;
        }
    }

    public void ChangeGreen()
    {
        switch (scriptvehicleButtons.vehicleIndex)
        {
            case 1:
                meshMaterials[0] = material[2];
                rend.materials = meshMaterials;
                break;
            case 2:
                meshMaterials[2] = material[2];
                rend.materials = meshMaterials;
                break;
            case 3:
                meshMaterials[2] = material[2];
                rend.materials = meshMaterials;
                break;
            case 4:
                meshMaterials[0] = material[2];
                rend.materials = meshMaterials;
                break;
            case 5:
                meshMaterials[1] = material[2];
                rend.materials = meshMaterials;
                break;
        }
    }

    public void ChangeBlue()
    {
        switch (scriptvehicleButtons.vehicleIndex)
        {
            case 1:
                meshMaterials[0] = material[3];
                rend.materials = meshMaterials;
                break;
            case 2:
                meshMaterials[2] = material[3];
                rend.materials = meshMaterials;
                break;
            case 3:
                meshMaterials[2] = material[3];
                rend.materials = meshMaterials;
                break;
            case 4:
                meshMaterials[0] = material[3];
                rend.materials = meshMaterials;
                break;
            case 5:
                meshMaterials[1] = material[3];
                rend.materials = meshMaterials;
                break;
        }
    }

    public void ChangeBlack()
    {
        switch (scriptvehicleButtons.vehicleIndex)
        {
            case 1:
                meshMaterials[0] = material[4];
                rend.materials = meshMaterials;
                break;
            case 2:
                meshMaterials[2] = material[4];
                rend.materials = meshMaterials;
                break;
            case 3:
                meshMaterials[2] = material[4];
                rend.materials = meshMaterials;
                break;
            case 4:
                meshMaterials[0] = material[4];
                rend.materials = meshMaterials;
                break;
            case 5:
                meshMaterials[1] = material[4];
                rend.materials = meshMaterials;
                break;
        }
    }
}