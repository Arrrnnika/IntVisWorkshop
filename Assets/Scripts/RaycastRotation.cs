using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRotation : MonoBehaviour
{

    private bool isRotating = false;
    
    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }
    }

    public void changeIsRot()
    {
        if (isRotating)
        {
            isRotating = false;
        } 
        else if (!isRotating)
        {
            isRotating = true;
        }
    }
}
