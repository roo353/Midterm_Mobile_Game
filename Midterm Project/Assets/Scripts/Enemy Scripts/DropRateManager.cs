using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRateManager : MonoBehaviour
{
    [System.Serializable]
    public class Drops
    {
        public string name;
        public GameObject itemPrefab;
        public float dropRate;
    }

    public List<Drops> drops;

    void OnDestroy()
    {
        float randomNumber = UnityEngine.Random.Range(0f, 100f);

        foreach (Drops rate in drops)
        {
            if(randomNumber <= rate.dropRate)
            {
                Instantiate(rate.itemPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
