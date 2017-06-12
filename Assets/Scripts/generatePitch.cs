using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePitch : MonoBehaviour {

    public float METERS_PER_FOOT = .3048f;

    public Pitch generatedPitch = new Pitch(89.69f, -1.4525731262329784f, 6.100778995183265f, 2000.2f, 247.2f, .6f, -0.026668930464195384f, 2.6292598316655056f);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1) & this.transform.localScale.y == 0f)
        {
            PlacePitch();
        }
        else if (Input.GetMouseButtonDown(1) & this.transform.localScale.y != 0f)
        {
            RemovePitch();
        }
	}

    void PlacePitch()
    {
        this.transform.localScale = new Vector3(.01f, .1f, .1f);
        this.transform.position = new Vector3((generatedPitch.GetPlateX() * METERS_PER_FOOT), generatedPitch.GetPlateZ() * METERS_PER_FOOT, -.12f);
        CustomMessages2.Instance.SendTargetData(2.0f, this.transform.position, this.transform.localScale);

    }

    void RemovePitch()
    {
        this.transform.localScale = new Vector3(.01f, 0f, 0f);
        this.transform.position = new Vector3(0f, .6f, -.12f);
        CustomMessages2.Instance.SendTargetData(2.0f, this.transform.position, this.transform.localScale);
    }
}
