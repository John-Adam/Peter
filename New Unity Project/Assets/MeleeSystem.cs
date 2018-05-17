using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class MeleeSystem : MonoBehaviour 
{ 
	public int damage = 25; public float distance; public float maxDistance = 1.5f; private RaycastHit hit; void Update () 
	{ 
		if (Input.GetButtonDown("Fire1")) 
		{ 
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
			{ 
				distance = hit.distance; if(distance < maxDistance) 
				{ 
					hit.transform.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
				} 
			}
		}
	}
}