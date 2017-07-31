using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDisplay : MonoBehaviour {

    public GameObject TargetManager;
    private TargetReceiver _TargetReceiver;
    public Target target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (TargetManager == null)
        {
            return;
        }

        _TargetReceiver = TargetManager.GetComponent<TargetReceiver>();
        //Debug.Log(_TargetReceiver.GetMessageType());
        if (_TargetReceiver == null)
        {
            return;
        }

        if (gameObject.name == "Target")
        {
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();
        }
        else if (gameObject.name == "Pitch")
        {
            this.transform.position = _TargetReceiver.GetPitchPosition();
            this.transform.localScale = _TargetReceiver.GetPitchSize();
        }

        if (_TargetReceiver.GetTargetColor() == 1.0f)
        {
            target.ShowIdle();
        }
        else if (_TargetReceiver.GetTargetColor() == 2.0f)
        {
            target.ShowHit();
        }
        else if (_TargetReceiver.GetTargetColor() == 3.0f)
        {
            target.ShowNearMiss();
        }
        else if (_TargetReceiver.GetTargetColor() == 4.0f)
        {
            target.ShowMiss();
        }
    }
}
