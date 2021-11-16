using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>(); // better than SerializeField, this way I just have to attach script to gameobject

        //sprite = GetComponent<SpriteRenderer>();

        // apparently, this doesn't take 0-255/256, it takes 0-1f. It took AGES to figure this out: https://docs.unity3d.com/2021.1/Documentation/ScriptReference/Color-ctor.html 
        // Note to self, look at the constructor methods next time.
        // Also, is it better to use the constructor, or set the values like this? I could make the code much smaller using the constructor, also probably reduce memory allocation.
       
        /* Bad Way
        Color floorColor = new Color();
        floorColor.a = 1f;
        floorColor.r = Random.value;
        floorColor.g = Random.value;
        floorColor.b = Random.value;

        sprite.color = floorColor; */

        // Possibly better way? Probably.
        sprite.color = new Color(Random.value, Random.value, Random.value, 1f);
    }
}