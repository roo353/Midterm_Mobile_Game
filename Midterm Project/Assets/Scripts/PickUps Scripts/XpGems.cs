using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpGems : MonoBehaviour, ICollectable
{

    public int xpGranted;

    public void Collect()
    {
        PlayerStats player = FindObjectOfType<PlayerStats>();
        player.IncreaseXP(xpGranted);
        Destroy(gameObject);
    }
}
