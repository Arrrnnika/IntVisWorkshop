using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer renderer;
    
    private Color color1 = Color.magenta;
    private Color color2 = Color.cyan;

    private bool isOnCol1 = true;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        if (isOnCol1)
        {
            renderer.material.color = color2;
            isOnCol1 = false;
        }
        else if (!isOnCol1)
        {
            renderer.material.color = color1;
            isOnCol1 = true;
        }
    }
}
