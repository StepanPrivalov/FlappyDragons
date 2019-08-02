using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
		{
			var projectile = GameObject.Instantiate(
			projectilePrefab, 
			transform.position + new Vector3(1.5f, 0.4f, 0), 
			projectilePrefab.transform.rotation);
		}
    }
}
