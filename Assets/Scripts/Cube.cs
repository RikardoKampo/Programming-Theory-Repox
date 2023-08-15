using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // INHERITANCE secondary
{

   void Update()
   {
      MoveShape();
      ColorShape();
      DestroyShapeDistance();
   }

   public override void ColorShape() // POLYMORPHISM
   {
      float colorRange = Random.Range(0.1f, 1);
      Material material = Renderer.material;
      material.color = new Color(colorRange, 1, 0.5f, 0.1f);
   }
}