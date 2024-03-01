using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    public GameObject startingWeapon;
    public float maxHealth;
    public float recovery;
    public float moveSpeed;
    public float might;
    public float projectileSpeed;
}
