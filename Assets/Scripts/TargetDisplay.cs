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
        else if (_TargetReceiver.GetMessageType() == 1.0f & gameObject.name == "Target")
        {
            Debug.Log(1);
            //Debug.Log(_TargetReceiver.GetTargetSize());
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();
            //Debug.Log(this.transform.localScale);

        }
        else if (_TargetReceiver.GetMessageType() == 2.0f & gameObject.name == "Pitch")
        {
            Debug.Log(2);
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();
        }
        else if (_TargetReceiver.GetMessageType() == 3.0f)
        {
            Debug.Log(3);
            target.ShowHit();
        }
        else if (_TargetReceiver.GetMessageType() == 4.0f)
        {
            Debug.Log(4);
            target.ShowNearMiss();
        }
        else if (_TargetReceiver.GetMessageType() == 5.0f)
        {
            Debug.Log(5);
            target.ShowMiss();
        }
        else if (_TargetReceiver.GetMessageType() == 6.0f)
        {
            Debug.Log(6);
            target.ShowIdle();
        }
    }
}
