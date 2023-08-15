using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Shape : MonoBehaviour // INHERITANCE primary
{
   private float m_shapeSpeed = 1.5f; // ENCAPSULATION
   public float shapeSpeed // ENCAPSULATION
   {
      get { return m_shapeSpeed; } // ENCAPSULATION

      set // ENCAPSULATION
      {
         if (value < 0.0f)
         {
            Debug.LogError("You can't set a speed!");
         }
         else
         {
            m_shapeSpeed = value; 
         }
      } // 
   }

   private float zRange = 8; 

   public MeshRenderer Renderer;

   public void MoveShape() // ABSTRACTION
   {
      transform.Translate(Vector3.back * Time.deltaTime * m_shapeSpeed);
   }

   public virtual void ColorShape() // ABSTRACTION
   {
      Material material = Renderer.material;
      material.color = new Color(0.1f, 0.5f, 0.5f, 0.1f);
   }

   public void DestroyShapeDistance() // ABSTRACTION
   {
      if (transform.position.z < -zRange)
      {
         Destroy(this.gameObject);
      }
   }

}