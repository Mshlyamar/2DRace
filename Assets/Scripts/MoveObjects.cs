using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
	public float speed;
   void FixedUpdate()
   {
      transform.Translate(Vector3.forward * Time.deltaTime);

      if(transform.position.y < -6)
      	Destroy(gameObject);
   }
}
