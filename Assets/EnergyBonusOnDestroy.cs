using UnityEngine;
using System.Collections;

public class EnergyBonusOnDestroy : MonoBehaviour
{
	public float energyBonus = 100;

	void OnDestroy()
	{
		EnergyManager.energy += energyBonus;
	}
}
