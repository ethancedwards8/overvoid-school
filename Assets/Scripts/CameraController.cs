using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Camera cam1;
    [SerializeField] Camera cam2;

    //\\------\\//

    public void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }


    public void enableCam(Camera camera)
    {
        if (Input.GetKey(KeyCode.C))
        {
            if (cam1.enabled)
            {
                cam1.enabled = false;
                cam2.enabled = true;
            }
            else
            {
                cam2.enabled = false;
                cam1.enabled = true;
            }
        }
    }
}
