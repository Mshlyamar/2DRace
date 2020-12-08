using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
	public float speed = 1.5f;
	public GameObject road;
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);

         if(transform.position.y < -10.01f){
         	Instantiate(road, new Vector3(-0.011f, 9.9f, 0), Quaternion.identity);
      		Destroy(gameObject);
      	}
    }
}
