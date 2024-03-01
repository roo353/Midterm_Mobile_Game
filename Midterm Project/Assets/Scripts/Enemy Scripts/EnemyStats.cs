using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public EnemyData enemyData;

    float currentMoveSpeed;
    float currentHealth;
    float currentDamage;

    void Awake()
    {
        currentMoveSpeed = enemyData.moveSpeed;
        currentHealth = enemyData.maxHealth;
        currentDamage = enemyData.damage;
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;

        if(currentHealth <= 0)
        {
            Kill();
        }
    }
    
    public void Kill()
    {
        Destroy(gameObject);
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            PlayerStats player = col.gameObject.GetComponent<PlayerStats>();
            player.TakeDamage(currentDamage);
        }
    }
}
