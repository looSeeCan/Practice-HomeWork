using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour//this script is attached on to the CarModelHolder, 
{//when the RedButton is clicked, the onClick is executed: carModelHolder > changeColor >changeColorRenderers, which then grabs the 
//coloValue from the ColorValueHolder, which can be changed in the RedButtpon inspector 
    public MeshRenderer [] renderers; //declare an array, which will show up on the inspector when the script is attached
    
    public void ChangeColorOnRenderers(ColorValueHolder colorValue)//Ask about this: Am I saying the class ColorValueHolder> then a variable that holds the class value
    {   
        // Debug.Log(colorValue);
        foreach(MeshRenderer rend in renderers)//MeshRenderer type. There are 2 values in this array that was referenced manually under the Renderers in the inspector
        {
            // Debug.Log(rend); //2 index values in the array rendereres
            // Debug.Log(colorValue.passedColor);
            rend.material.color = colorValue.passedColor; //so, the colorValueHolder script that is attached to the RedButton has a passedColor component that
            //we can change on the inspector.
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
