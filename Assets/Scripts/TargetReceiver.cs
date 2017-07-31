using HoloToolkit.Sharing;
using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;

// Receives the body data messages
public class TargetReceiver : Singleton<TargetReceiver>
{
    private float targetColor;
    private Vector3 targetPosition = new Vector3();
    private Vector3 targetSize = new Vector3();
    private Vector3 pitchPosition = new Vector3();
    private Vector3 pitchSize = new Vector3();

    public float GetTargetColor()
    {
        return targetColor;
    }

    public Vector3 GetTargetPosition()
    {
        return targetPosition;
    }

    public Vector3 GetTargetSize()
    {
        return targetSize;
    }

    public Vector3 GetPitchPosition()
    {
        return pitchPosition;
    }

    public Vector3 GetPitchSize()
    {
        return pitchSize;
    }

    void Start()
    {
        CustomMessages2.Instance.MessageHandlers[CustomMessages2.TestMessageID.TargetData] =
            this.UpdateHololensData;
    }

    // Called when reading in TargetData
    void UpdateHololensData(NetworkInMessage msg)
    {
        targetColor = msg.ReadFloat();
        targetPosition = CustomMessages2.Instance.ReadVector3(msg);
        targetSize = CustomMessages2.Instance.ReadVector3(msg);
        pitchPosition = CustomMessages2.Instance.ReadVector3(msg);
        pitchSize = CustomMessages2.Instance.ReadVector3(msg);

    }
}