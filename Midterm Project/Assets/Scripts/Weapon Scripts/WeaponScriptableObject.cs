using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponScriptableObject : ScriptableObject
{
    public GameObject prefab;

    //Base Weapon Stats
    public float damage;
    public float speed;
    public float coolDownDuration;
    public int pierce;
}
