using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script that holds base weapon stats
public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public GameObject prefab;
    public float damage;
    public float speed;
    public float coolDownDuration;
    float currentCooldown;
    public int pierce;

    protected PlayerMovement pm;

    protected virtual void Start()
    {
        pm = FindObjectOfType<PlayerMovement>();
        currentCooldown = coolDownDuration;
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
        currentCooldown = coolDownDuration; //Created infinite loop of attack every set ammount of time
    }
}
