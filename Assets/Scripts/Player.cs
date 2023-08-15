using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour
{
   [SerializeField] private float xRange = 5;
   
   void Update()
   {
      MovePlayer();

   }

   private void MovePlayer() // ABSTRACTION
   {
      float speed = 1.0f;
      float horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

      if (transform.position.x < -xRange)
      {
         transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }

      if (transform.position.x > xRange)
      {
         transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Shape"))
      {
         Destroy(other.gameObject);
      }
   }
}

