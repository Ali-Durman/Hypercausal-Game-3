using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform Target;
    public float CameraFollowSpeed = 0.125f;
    public Vector3 offset;
    private void FixedUpdate()
    {
        Vector3 desiredPos = Target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, CameraFollowSpeed); // Lerpi Öðren
        transform.position = smoothedPos;
    }
}
