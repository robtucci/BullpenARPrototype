using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public Color IdleColor = Color.blue;
    public Color HitColor = Color.green;
    public Color NearMissColor = Color.yellow;
    public Color MissColor = Color.red;
    private Renderer _Renderer;

	// Use this for initialization
	void Start () {
        _Renderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	public void ShowHit()
    {
        _Renderer.sharedMaterial.color = HitColor;
    }

    public void ShowNearMiss()
    {
        _Renderer.sharedMaterial.color = NearMissColor;
    }

    public void ShowMiss()
    {
        _Renderer.sharedMaterial.color = MissColor;
    }

    public void ShowIdle()
    {
        _Renderer.sharedMaterial.color = IdleColor;
    }

}
