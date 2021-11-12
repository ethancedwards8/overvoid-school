using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Directions
{
    NORTH,
    EAST,
    SOUTH,
    WEST
}

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GameObject currentMap;
    private Boundaries currentMapBoundaries;

    [SerializeField] GameObject currentTile;

    void Start()
    {
        currentMapBoundaries = currentMap.GetComponent<Boundaries>();
        Debug.Log(currentTile.GetComponent<SpaceTile>().getDescription());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            move(Directions.NORTH);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            move(Directions.EAST);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            move(Directions.SOUTH);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            move(Directions.WEST);
        else
            ;
    }

    public void move(Directions where)
    {
        float xOffset = 0, yOffset = 0;
        
        // probably should be a helper function, we should look into a "Utility" class.
        switch (where) {
            case Directions.NORTH:
                yOffset = 1;
                break;

            case Directions.EAST:
                xOffset = 1;
                break;

            case Directions.SOUTH:
                yOffset = -1;
                break;

            case Directions.WEST:
                xOffset = -1;
                break;

            default:
                break;
        }

        // checks the bounds, then moves the player
        if (currentMapBoundaries.checkBounds(transform, xOffset, yOffset) && checkTile(where)) {
            switch (where) {
                case Directions.NORTH:
                    transform.position += Vector3.up;
                    break;

                case Directions.EAST:
                    transform.position += Vector3.left;
                    break;

                case Directions.SOUTH:
                    transform.position += Vector3.down;
                    break;

                case Directions.WEST:
                    transform.position += Vector3.right;
                    break;

                default:
                    break;
            }
        }
    }

    public bool checkTile(Directions tileDir)
    {
        bool found = false;

        return found;
    }
}
