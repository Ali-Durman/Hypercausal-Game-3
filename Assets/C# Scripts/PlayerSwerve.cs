using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwerve : MonoBehaviour
{
    private float LastFingerPosX;
    private float MoveFactorX;
    public float moveFacx => MoveFactorX;
    public static PlayerSwerve Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            MoveFactorX = Input.mousePosition.x - LastFingerPosX;
            LastFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            MoveFactorX = 0f;
        }
    }
}
