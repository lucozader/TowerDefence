using UnityEngine;
using System.Collections;

public class CreateTowerOnClicked : MonoBehaviour
{
	bool empty = true;
	public TowerSelector towerSelector;
	
	void Clicked(Vector3 position)
	{
		if(EnergyManager.energy >= towerSelector.GetSelectedTowerCost()&& empty == true)
		{ Debug.Log(position.x);
			Debug.Log(position.z);
			//if(position.x>-14 &&position.x<-9&& position.z >6 && position.z <10){
			GameObject tower = towerSelector.GetSelectedTower();
			Instantiate(tower,transform.position + Vector3.up*30f,tower.transform.rotation);
			EnergyManager.energy -= towerSelector.GetSelectedTowerCost();//}
			
			empty = false;
			
		}
	}
}
