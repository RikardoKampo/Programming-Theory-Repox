using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
   // Start is called before the first frame update
   void Start()
   {
      ColorShape();
   }

   // Update is called once per frame
   void Update()
   {
      MoveShape();
      DestroyShapeDistance();
   }

   public override void ColorShape()
   {
      float colorRange = Random.Range(0.1f, 1);
      Material material = Renderer.material;
      material.color = new Color((1 - colorRange), 0.5f, colorRange, 1);
   }
}
