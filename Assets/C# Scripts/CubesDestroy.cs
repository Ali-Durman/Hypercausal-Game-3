using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesDestroy : MonoBehaviour
{
    public GameObject Painteffect;   
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coin"))
        {
            GetComponent<MeshRenderer>().material.color = col.gameObject.GetComponent<MeshRenderer>().material.color;
            UIScore.Instance.ScoreInCrease();
            Destroy(col.gameObject);
            Instantiate(Painteffect, transform.position, transform.rotation);
        }
    }
}
