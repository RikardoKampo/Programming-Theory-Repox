using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // INHERITANCE secondary
{
   void Update()
   {
      MoveShape();
      ColorShape();
      DestroyShapeDistance();
   }

}