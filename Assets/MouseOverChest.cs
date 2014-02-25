using UnityEngine;
using System.Collections;

public class MouseOverChest : MonoBehaviour {

	void OnMouseEnter()
	{
		//move treasure chest to money and increase money by 100

		EnergyManager.energy += 100;
		Debug.Log("MOUSE ENTERED");
	}

}
