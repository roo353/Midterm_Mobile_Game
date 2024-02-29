using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script used on all projectile weapon prefabs
public class ProjectileWeaponBehavior : MonoBehaviour
{
    protected Vector3 direction;
    public float destroyAfterSeconds;

    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
