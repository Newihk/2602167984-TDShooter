using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamBehaviour : ProjectileWeapon
{
    BeamController bc;
    protected override void Start()
    {
        base.Start();
        bc = FindObjectOfType<BeamController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * bc.speed * Time.deltaTime;
    }
}
