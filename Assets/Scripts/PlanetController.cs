using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// the different planet types
public enum EPlanetType
{
    RADIOACTIVE, // earth like, but fallout like radioactivity 
    VOLCANIC,
    JUNGLE,
    ARCTIC
}

// the resources that the planet has: fairly simple
public enum EPlanetResource
{
    FUEL,
    OXYGEN,
    FOOD,
    WATER
}

public class PlanetController : MonoBehaviour
{
    // signifies if the planet is a dwarf planet
    [SerializeField] private bool dwarf = false;
    [SerializeField] private bool deleteAfterVisit = false;

    // the sprite that the planet will use
    [SerializeField] private Sprite sprite;

    // planet types/resources
    [SerializeField] public EPlanetType planetType; // the planetType will be set in the inspector, everything else revolves around it
    public EPlanetResource planetResource;

    void Start()
    {
        aTWR(planetType); // the planet type has an associated resource, this sets it
    }

    /////////////// FUNCTIONS/METHODS:

    // will "destroy" the planet: in reality hides it
    public void destroyPlanet()
    {
        gameObject.SetActive(false);
    }

    // this method associates the planet type with the planet resource: aka: setting planet resource based off the planet type
    // aTWR - short for associateTypeWithResource - it was changed in protest by the group/democracy
    public void aTWR(EPlanetType type)
    {
        switch (type)
        {
            case EPlanetType.RADIOACTIVE:
                setPlanetResource(EPlanetResource.FUEL);
                break;

            case EPlanetType.VOLCANIC:
                setPlanetResource(EPlanetResource.OXYGEN);
                break;

            case EPlanetType.JUNGLE:
                setPlanetResource(EPlanetResource.FOOD);
                break;

            case EPlanetType.ARCTIC:
                setPlanetResource(EPlanetResource.WATER);
                break;

            default:
                Debug.Log("Error"); 
                break;
        }
    }


    // simple get'ers and set'ers 
    private void setPlanetType(EPlanetType type)
    {
        this.planetType = type;
    }

    private void setPlanetResource(EPlanetResource resource)
    {
        this.planetResource = resource;
    }

    public EPlanetType getPlanetType()
    {
        return this.planetType;
    }

    public EPlanetResource getPlanetResource()
    {
        return this.planetResource;
    }

}
