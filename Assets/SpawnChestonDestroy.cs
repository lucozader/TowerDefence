using UnityEngine;
using System.Collections;

public class SpawnChestonDestroy : MonoBehaviour {
	public GameObject chest;

	void OnDestroy()
	{
		//EnergyManager.energy += energyBonus;
	//	Quaternion pathObjectOrientation = Quaternion.LookRotation(pathPoints[0].transform.position - transform.position);
		GameObject reference = Instantiate(chest, transform.position, Quaternion.identity) as GameObject;
	}
}
