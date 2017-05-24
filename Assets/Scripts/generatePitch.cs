using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePitch : MonoBehaviour {


    public Pitch generatedPitch = new Pitch(89.69f, -1.4525731262329784f, 6.100778995183265f, 2000.2f, 247.2f, .6f, -0.026668930464195384f, 2.6292598316655056f);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(1))
        {
            PlacePitch();
        }
	}

    void PlacePitch()
    {
        this.transform.localScale = new Vector3(.01f, .1f, .1f);
        this.transform.position = new Vector3((generatedPitch.GetPlateX() * .3048f), generatedPitch.GetPlateZ() * .3048f, -.12f);

    }
}
