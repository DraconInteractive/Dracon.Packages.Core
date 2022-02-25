using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexaRef : MonoBehaviour
{
    public static HexaRef Instance;
    
    private void Awake()
    {
        Instance = this;
    }
#if HEXA
    public HexabodyVR.PlayerController.HexaBodyPlayer3 controller;

    public void FaceDirection(Vector3 dir)
    {
        controller.FaceDirection(dir);
    }
    public void MoveToPosition_NoHands(Vector3 locoBallBottom)
    {
        Transform head = controller.HeadRigidbody.transform;
        Transform locoball = controller.LocoBall.transform;
        Transform torso = controller.Torso.transform;
        Transform knee = controller.Knee.transform;

        var offsetHead = head.position - locoball.position;
        var offsetTorso = torso.position - locoball.position;
        var offsetKnee = knee.position - locoball.position;

        locoball.position = locoBallBottom + new Vector3(0, controller.LocoCollider.radius, 0f);

        head.position = locoball.position + offsetHead;
        torso.position = locoball.position + offsetTorso;
        knee.position = locoball.position + offsetKnee;

        controller.Stop();
    }

#endif

}
