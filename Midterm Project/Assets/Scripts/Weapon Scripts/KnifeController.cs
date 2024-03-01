using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedKnife = Instantiate(weaponData.prefab);
        spawnedKnife.transform.position = transform.position; //assigns object to the Knife Controller on the player
        spawnedKnife.GetComponent<KnifeBehavior>().DirectionChecker(pm.moveDir);
    }
}
