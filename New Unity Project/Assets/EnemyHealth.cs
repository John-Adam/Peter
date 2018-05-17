using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
public class EnemyHealth : MonoBehaviour 
{ 
	public int health = 100; void ApplyDamage (int damage) 
	{ 
		health -= damage; 
		if (health <= 0) 
		{
			Dead(); 
		} 
	} 
	void Dead() 
	{ Destroy(gameObject); 
	} 
}