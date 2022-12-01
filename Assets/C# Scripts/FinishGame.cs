using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject Fireworkspart;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Finish"))
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Instantiate(Fireworkspart, col.transform.position, Quaternion.identity);
            PlayerMove.Instance.isMoving = false;
            PlayerSwerve.Instance.enabled = false;
        }

    }
}
