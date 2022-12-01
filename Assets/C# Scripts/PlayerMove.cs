using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool isMoving;
    public float Speed = 1f;
    public static PlayerMove Instance;
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
    void Update()
    {
        if (!isMoving) return;
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
}
