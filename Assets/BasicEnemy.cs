using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {
	
	public float health = 10;
	public static float increase1 = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag == "Bullet")
		{
			health= health - (health+ increase1*(health/100));
			Destroy(collision.collider.gameObject);
		}
			if(collision.collider.tag == "Explosion")
		{
			health = health -5;
			Destroy(collision.collider.gameObject);
		}
	
		if(health <= 0)
		{
			Destroy(collision.collider.gameObject);
			Destroy(gameObject);
		}
	}
}
