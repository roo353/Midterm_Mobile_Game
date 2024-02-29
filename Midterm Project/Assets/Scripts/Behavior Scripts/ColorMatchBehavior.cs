using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj;

   private void Awake()
   {
        idObj = colorIDDataListObj.currentColor;
   } 

   public void ChangeColor(SpriteRenderer renderer)
   {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
   }
}
