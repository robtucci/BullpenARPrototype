using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    public float scaleSpeed = 5;
    private float mouseSize = 1;
   
    private Ray ray;
    private RaycastHit hit;



    

    // Use this for initialization
    void Start () {

	}

// Update is called once per frame
    void Update()
    {

        MoveCursor();   //move the cursor based on user click

        ScaleCursor();   //scale cursor based on use of the scrollwheel


    }

    private void MoveCursor()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.name == "StrikeZone")   //if the object we hit is the strikeZone Object,
                {
                    this.transform.position = hit.point;
                    this.transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                }

                Debug.Log(hit.point);
            }

        }
    }

    private void ScaleCursor()
    {
        float mouseChange = Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * scaleSpeed;


        mouseSize += mouseChange;
        Debug.Log(mouseSize);

        this.transform.localScale = new Vector3(mouseSize, 1, mouseSize);
    }

}
