using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour {

    private bool rotate;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3 (1, Mathf.Sqrt(2), 1);
        var x = Mathf.Sqrt(2);

	}

    public void rotateOnOff()
    {
        if (rotate == true)
            rotate = false;
        else
            rotate = true;
    }

	
	// Update is called once per frame
	void Update () {

        if (rotate)
        {
            var eulers = transform.rotation.eulerAngles;
            transform.Rotate(new Vector3(0.0f, 0.1f, 0f));
            Debug.Log(eulers.x + ", " + eulers.y + ", " + eulers.z);
        }


	}
}
