using UnityEngine;
using System.Collections;

public class PathThroughObjects : MonoBehaviour
{
	public GameObject[] pathPoints;
	public float speed = 1.0f;
	//public float goalSize = 0.1f;
	
	private int currentPathIndex = 0;
	private Vector3 movementDirection;
	
	void Start()
	{
		movementDirection = (pathPoints[currentPathIndex].transform.position - transform.position).normalized;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		//movement code
		transform.position += movementDirection*speed*Time.deltaTime;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == pathPoints[currentPathIndex].name)
		{
			transform.position = pathPoints[currentPathIndex].transform.position;
			currentPathIndex++;
			if(currentPathIndex >= pathPoints.Length)
			{
				GUIControllerFireEmblem.planetHealthLeft = GUIControllerFireEmblem.planetHealthLeft-5;//ADD LOGIC HERE TO DEDUCT HEALTH FROM PLAYER/BASE
				Destroy(gameObject);
			}
			else
			{
				movementDirection = (pathPoints[currentPathIndex].transform.position - transform.position).normalized;
			}
		}
	}
	
	void SetPathPoints(GameObject[] inputPathPoints)
	{
		pathPoints = inputPathPoints;
	}
}
