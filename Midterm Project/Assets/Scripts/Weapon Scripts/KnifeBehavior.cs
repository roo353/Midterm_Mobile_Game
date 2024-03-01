using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeBehavior : ProjectileWeaponBehavior
{

    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        transform.position += direction * weaponData.speed * Time.deltaTime;
    }
}
