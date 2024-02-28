using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor (ColorID obj)
    {
        rendererObj.color = obj.value;        
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }

    public void DestroyMatchingObjects()
    {
        Destroy(gameObject);
    }
}
