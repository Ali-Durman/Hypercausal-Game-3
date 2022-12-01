using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    [SerializeField] private float SwerveSpeed = 0.5f;
    [SerializeField] private float MaxSwerveAmount = 1f;
    private PlayerSwerve Playerswerve;
    // Start is called before the first frame update
    private void Awake()
    {
        Playerswerve = GetComponent<PlayerSwerve>();
    }

    // Update is called once per frame
    private void Update()
    {
        float swerveamount = Time.deltaTime * SwerveSpeed * Playerswerve.moveFacx;
        swerveamount = Mathf.Clamp(value: swerveamount, min: -MaxSwerveAmount, MaxSwerveAmount);
        transform.Translate(swerveamount, 0, 0);
    }
}
