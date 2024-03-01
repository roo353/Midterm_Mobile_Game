using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.TryGetComponent(out ICollectable collectable))
        {
            collectable.Collect();
        }
    }
}
