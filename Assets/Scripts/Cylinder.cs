using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
   void Update()
   {
      MoveShape();
      ColorShape();
      DestroyShapeDistance();
   }

}