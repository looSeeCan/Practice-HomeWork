using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//added this nameSpace for the Slider component

public class RotateSunSkyBox : MonoBehaviour //this script is attached to the Directional light Game Object
{
    private Light directionalLight;//add to our script, the abillity to dim the lights. A reference to the Directionan Light.
    public Gradient timeOfDayColor;
    public AnimationCurve intensityGraph;
    public void RotateSun(Slider passedSlider)//I had an issue with this. Slider is a UI element. I was getting an error for it. I had to add the namespace "using UnityEngine UI" above
    {
        // Debug.Log($"passedSlider: {passedSlider}");
        Quaternion newRot = Quaternion.Euler(passedSlider.value, transform.rotation.y, transform.rotation.z);
        transform.rotation = newRot;
        float betweenZeroAndOne = (passedSlider.value - passedSlider.minValue) / (passedSlider.maxValue - passedSlider.minValue);//this calculation returns a fraction between zero and one no matter wht the min and max values of the slider are. The Gradient and AnimationCurve Evaluate funtion uses values between zero and one
        directionalLight.color = timeOfDayColor.Evaluate(betweenZeroAndOne);
        directionalLight.intensity = intensityGraph.Evaluate(betweenZeroAndOne);
    }//after the method is created, call the method from our OnValueChanged, passing the Slider component. The OnValueChanged method
    //is on the inspector of the TimeOfDay slider.

    // Start is called before the first frame update
    void Start()
    {
        directionalLight = GetComponent<Light>();//abillity to dim the lights.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
