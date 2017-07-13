using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// On right click, grabs the next pitch in the array and displays it.
/// </summary>

public class PitchController : MonoBehaviour {

    private static float METERS_PER_FOOT = .3048f;
    private bool isDisplayed = false;


    private Pitch[] pitches = new Pitch[3];
    public Transform parent;
    public GameObject pitchPrefab;
    public Target target;
    //public GameObject targetObject;

    private int currentPitchIndex = 0;
    private Pitch currentPitch;
    private GameObject currentPitchObject;


    // Use this for initialization
    void Start()
    {
        pitches[0] = new Pitch(90.2f, -1.47893849834849834f, 6.12984394f, 1800.5f, 247.2f, .58f, -.03f, 2.8f);
        pitches[1] = new Pitch(-0.23946323409252668f, 2.6122260971763467f);
        pitches[2] = new Pitch(0.5934264309305093f, 1.2603331747030513f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) & isDisplayed == false)
        {
            PlacePitch();
        }
        else if (Input.GetMouseButtonDown(1) & isDisplayed)
        {
            RemovePitch();
        }
    }

    void PlacePitch()
    {
        //get next pitch in the array

        Debug.Log("Pitches Length: " + pitches.Length);

        if (currentPitchIndex < pitches.Length-1)  //if there is still on index left to use
        {
            currentPitchIndex++;  //grab next pitch
        }

        else
        {
            currentPitchIndex = 0;  //reset to first in the index.
        }

        currentPitch = pitches[currentPitchIndex];
        currentPitchObject = Instantiate(pitchPrefab, new Vector3(currentPitch.plateX * METERS_PER_FOOT, currentPitch.plateZ * METERS_PER_FOOT, -0.11f), Quaternion.identity, parent);

        isDisplayed = true;

        CheckOutcome();

        //this.transform.position = new Vector3((generatedPitch.plateX * METERS_PER_FOOT), generatedPitch.plateZ * METERS_PER_FOOT, 0f);
        //CustomMessages2.Instance.SendTargetData(2.0f, this.transform.position, this.transform.localScale);

    }

    void RemovePitch()
    {
        //this.transform.localScale = new Vector3(.01f, 0f, 0f);
        isDisplayed = false;
        Destroy(currentPitchObject); // need to fix this, it's super inefficient to keep instantiating and destroying, should use an object pool

        target.ShowIdle();
        

        //CustomMessages2.Instance.SendTargetData(2.0f, this.transform.position, this.transform.localScale);
    }


    //Determine if pitch hit the target, came close, or missed completely.
    void CheckOutcome()
    {
        Debug.Log(Vector3.Distance(currentPitchObject.transform.position, target.transform.position));

        Debug.Log("Local scale.x: " + target.transform.localScale.x);

        if (Vector3.Distance(currentPitchObject.transform.position, target.transform.position) < ((target.transform.localScale.x/2) + 0.035f))   //need to combine the radius of the ball and the radius of the target for the max allowed distance
        {
            Debug.Log("Hit.");
            target.ShowHit();
        }
        else if (Vector3.Distance(currentPitchObject.transform.position, target.transform.position) < ((target.transform.localScale.x) + 0.035f))
        {
            Debug.Log("Near miss.");
            target.ShowNearMiss();
        }
        else
        {
            Debug.Log("Miss.");
            target.ShowMiss();
        }
    }
}

