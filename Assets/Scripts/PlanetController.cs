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
    [SerializeField] private bool randomizesColor = false;
    private int resourceAmount;
    public bool depleted = false;
    public InventoryItem finalResource;

    // the sprite that the planet will use
    [SerializeField] private Sprite sprite;

    // planet types/resources
    [SerializeField] private EPlanetType planetType; // the planetType will be set in the inspector, everything else revolves around it
    private EPlanetResource planetResource;

    void Start()
    {
        aTWR(planetType); // the planet type has an associated resource, this sets it
        gameObject.GetComponent<SpriteRenderer>().sprite = this.sprite;

        if (dwarf)
            resourceAmount = Random.Range(1, 3);
        else
            resourceAmount = Random.Range(3, 5);

        finalResource.value = resourceAmount;
        finalResource.type = planetResource;

        if (randomizesColor)
            GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, .2f, .7f, .7f, .98f, 1f, 1f);
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
                PlanetResource = EPlanetResource.FUEL;
                break;

            case EPlanetType.VOLCANIC:
                PlanetResource = EPlanetResource.OXYGEN;
                break;

            case EPlanetType.JUNGLE:
                PlanetResource = EPlanetResource.FOOD;
                break;

            case EPlanetType.ARCTIC:
                PlanetResource = EPlanetResource.WATER;
                break;

            default:
                Debug.Log("Error"); 
                break;
        }
    }

    public EPlanetType PlanetType
    {
        get { return planetType; }
        set { planetType = value; }
    }

    public EPlanetResource PlanetResource
    {
        get { return planetResource; }
        set { planetResource = value; }
    }

    public int ResourceAmount
    {
        get { return resourceAmount; }
        set { resourceAmount = value; }
    }

}
