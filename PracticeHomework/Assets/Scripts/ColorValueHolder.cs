using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorValueHolder : MonoBehaviour
{
    //the event system of the Button, OnClick() cannot pass Color values to methods
    //Deleted the Start() and Updated methods. The only thing this class will contain is a declaration of public Color passedColor

    public Color passedColor;
    
}
