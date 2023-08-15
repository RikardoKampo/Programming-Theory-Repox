using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Shape : MonoBehaviour
{
   private float m_shapeSpeed = 1.5f;
   public float shapeSpeed
   {
      get { return m_shapeSpeed; } // getter returns backing field

      set
      {
         if (value < 0.0f)
         {
            Debug.LogError("You can't set a negative production speed!");
         }
         else
         {
            m_shapeSpeed = value; // original setter now in if/else statement
         }
      } // setter uses backing field
   }

   private float zRange = 8;
   // Start is called before the first frame update
   void Start()
   {

   }
   public MeshRenderer Renderer;
   // Update is called once per frame
   void Update()
   {
      MoveShape();
      ColorShape();
   }

   public void MoveShape()
   {
      transform.Translate(Vector3.back * Time.deltaTime * m_shapeSpeed);
   }

   public virtual void ColorShape()
   {
      Material material = Renderer.material;
      material.color = new Color(0.1f, 0.5f, 0.5f, 0.1f);
   }

   public void DestroyShapeDistance()
   {
      if (transform.position.z < -zRange)
      {
         Destroy(this.gameObject);
      }
   }

}