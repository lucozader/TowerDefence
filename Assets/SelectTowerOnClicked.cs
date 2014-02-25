using UnityEngine;
using System.Collections;

public class SelectTowerOnClicked : MonoBehaviour {
	
	public GameObject towerSelector;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Clicked()
	{
		//Tell the tower selector to change the selected tower
		towerSelector.SendMessage("SetSelectedTower", gameObject);
	}
}
