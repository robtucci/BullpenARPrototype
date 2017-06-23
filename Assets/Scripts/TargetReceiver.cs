using HoloToolkit.Sharing;
using HoloToolkit.Unity;
using System.Collections.Generic;
using UnityEngine;

// Receives the body data messages
public class TargetReceiver : Singleton<TargetReceiver>
{
    private float messageType;
    private Vector3 targetPosition = new Vector3();
    private Vector3 targetSize = new Vector3();

    public float GetMessageType()
    {
        return messageType;
    }

    public Vector3 GetTargetPosition()
    {
        return targetPosition;
    }

    public Vector3 GetTargetSize()
    {
        return targetSize;
    }

    void Start()
    {
        CustomMessages2.Instance.MessageHandlers[CustomMessages2.TestMessageID.TargetData] =
            this.UpdateTargetData;
    }

    // Called when reading in TargetData
    void UpdateTargetData(NetworkInMessage msg)
    {
        messageType = msg.ReadFloat();
        Debug.Log(messageType);
        targetPosition = CustomMessages2.Instance.ReadVector3(msg);
        Debug.Log(targetPosition);
        targetSize = CustomMessages2.Instance.ReadVector3(msg);
        Debug.Log(targetSize);
    }
}