using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

	public float SCALE_SPEED = .5f;
	public float STARTING_CURSOR_SIZE = 0.07f;
    public float MIN_CURSOR_SIZE = 0.07f;
    public float MAX_CURSOR_SIZE = 5.0f;

    private Ray ray;
	private RaycastHit hit;


	

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			MoveCursor();   //move the cursor based on user click
		}

		if (Input.GetAxis("Mouse ScrollWheel") > 0f || Input.GetAxis("Mouse ScrollWheel") < 0f)
		{
			ScaleCursor();   //scale cursor based on use of the scrollwheel
		}

	}

	private void MoveCursor()
	{

		ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider.name == "StrikeZone")   //if the object we hit is the strikeZone Object,
			{
				if (this.transform.localScale.x == 0)
				{
					this.transform.localScale = new Vector3(STARTING_CURSOR_SIZE,STARTING_CURSOR_SIZE,STARTING_CURSOR_SIZE);
				}
				this.transform.position = new Vector3(hit.point.x, hit.point.y, -0.1f);   //take the x,y from the ray hit, but not the z (to prevent it intersecting the gridlines
				this.transform.rotation = Quaternion.Euler(-90, 180, 180);
				CustomMessages2.Instance.SendTargetData(1.0f,this.transform.position, this.transform.localScale);
			
			}
		}

		
	}

	private void ScaleCursor()
	{

		float cursorSize = this.transform.localScale.x;

		float cursorChange = Input.GetAxis("Mouse ScrollWheel") * SCALE_SPEED;


		cursorSize += cursorChange;
		cursorSize = Mathf.Min(MAX_CURSOR_SIZE, cursorSize);
		cursorSize = Mathf.Max(MIN_CURSOR_SIZE, cursorSize);

		this.transform.localScale = new Vector3(cursorSize,0.01f,cursorSize);
		CustomMessages2.Instance.SendTargetData(1.0f,this.transform.position, this.transform.localScale);
	}

}
