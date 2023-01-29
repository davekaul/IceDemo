using System.Collections;
using System.Collections.Generic;
using UIHealthAlchemy;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private PowerBarMaterial powerBarMaterial;

    [Range(0, 1)] public float bleedRate;

    private void Awake()
    {
        powerBarMaterial = GetComponentInChildren<PowerBarMaterial>();
        powerBarMaterial.Value = 1f;
    }


    private void Update()
    {
        powerBarMaterial.Value -= bleedRate * Time.deltaTime;
        
        if (powerBarMaterial.Value <= 0f)
        {
            Debug.Log("You're dead!!!");
        }
    }
}
