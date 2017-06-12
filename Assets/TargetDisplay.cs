using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDisplay : MonoBehaviour {

    public GameObject TargetManager;
    private TargetReceiver _TargetReceiver;

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
        else if (_TargetReceiver.GetMessageType() == 63 & gameObject.name == "Cursor")
        {
            //Debug.Log(_TargetReceiver.GetTargetSize());
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();
            //Debug.Log(this.transform.localScale);

        }
        else if (_TargetReceiver.GetMessageType() == 64 & gameObject.name == "Pitch")
        {
            //Debug.Log(_TargetReceiver.GetTargetPosition());
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();
        }

    }
}
