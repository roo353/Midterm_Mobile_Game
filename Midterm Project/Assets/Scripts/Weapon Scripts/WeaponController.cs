using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that holds base weapon stats
public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public WeaponScriptableObject weaponData;
    float currentCooldown;

    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        currentCooldown = weaponData.coolDownDuration;
    }

    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime; //Attack when cooldown = 0
        if(currentCooldown <= 0f)
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = weaponData.coolDownDuration; //Created infinite loop of attack every set ammount of time
    }
}
