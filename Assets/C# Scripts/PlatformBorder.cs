using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBorder : MonoBehaviour
{
    public float MinX;
    public float MaxX;
    // Update is called once per frame
    void Update()
    {
        float xPos = Mathf.Clamp(transform.position.x, MinX, MaxX);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
