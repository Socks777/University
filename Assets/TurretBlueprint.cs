using UnityEngine;
using System.Collections;

[System.Serializable] //saves and loads the values for me and making ti editable
public class TurretBlueprint {

	public GameObject prefab;
	public int cost;
	public GameObject upgradedPrefab;
	public int upgradeCost;

	public int GetSellAmount ()
	{
		return cost / 2;
	}


}