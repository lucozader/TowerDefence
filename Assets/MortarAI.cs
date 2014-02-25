using UnityEngine;
using System.Collections;

public class MortarAI : MonoBehaviour
{
	public GameObject explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Instantiate(explosion, collision.contacts[0].point, Quaternion.identity);
		Destroy(gameObject);
	}
}
