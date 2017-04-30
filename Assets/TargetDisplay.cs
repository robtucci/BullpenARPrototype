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

        _TargetReceiver = BodySourceManager.GetComponent<BodyDataReceiver>();
        if (_TargetReceiver == null)
        {
            return;
        }
        else
        {
            this.transform.position = _TargetReceiver.GetTargetPosition();
            this.transform.localScale = _TargetReceiver.GetTargetSize();

        }

    }
}
