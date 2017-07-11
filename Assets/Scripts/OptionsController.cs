using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider OpacitySlider;
    public Slider RedSlider;
    public Slider GreenSlider;
    public Slider BlueSlider;
    public Toggle OutlineToggle;
    public Toggle GridToggle;
    public GameObject StrikeZoneObject;   //in the unity editor, link the strikezone gameObject to this script
    public GameObject OutlineObject;  //in the unity editor, link the Outline gameObject to this script
    public GameObject GridObject;        //in the unity editor, link the Grid gameObject to this script
    private Renderer StrikeZoneRend;    //mesh renderer for the strike zone
    private float opacity;
    private float redValue;
    private float blueValue;
    private float greenValue;
    private bool OutlineOn;
    private bool GridOn;

	// Use this for initialization
	void Start () {
        StrikeZoneRend = StrikeZoneObject.GetComponent<Renderer>();
        Debug.Log(StrikeZoneRend);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (opacity != OpacitySlider.value)   //if the value in the slider has changed, call updateOpacity method.
        {
            opacity = OpacitySlider.value;
            UpdateOpacity();
        }
        if (redValue != RedSlider.value || blueValue != BlueSlider.value || greenValue != GreenSlider.value)   //if any of the color slider values have changed, update color
        {
            redValue = RedSlider.value;
            greenValue = GreenSlider.value;
            blueValue = BlueSlider.value;


            UpdateColor();
        }

        if (OutlineToggle.isOn != OutlineOn)
        {
            OutlineOn = OutlineToggle.isOn;
            UpdateOutline();
        }

        if (GridToggle.isOn != GridOn)
        {
            GridOn = GridToggle.isOn;
            UpdateGrid();
        }


        

	}

    void UpdateOpacity()    //update the opacity of the meshrenderer on the strikezone object.
    {
        Color newColor = StrikeZoneRend.sharedMaterial.color;
        newColor.a = opacity;
        StrikeZoneRend.sharedMaterial.color = newColor;
    }

    void UpdateColor()
    {
        Color newColor = StrikeZoneRend.sharedMaterial.color;
        newColor.r = redValue;
        newColor.g = greenValue;
        newColor.b = blueValue;
        StrikeZoneRend.sharedMaterial.color = newColor;

    }

    void UpdateOutline()  //Toggle the Outline of the strikezone on/off
    {
        OutlineObject.SetActive(OutlineOn);
    }

    void UpdateGrid()   //Toggle the Grid display on/off
    {
        GridObject.SetActive(GridOn);
    }
}
