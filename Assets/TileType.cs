using UnityEngine;
using System.Collections;

[System.Serializable]
public class TileType {

	public string name;
	public GameObject tileVisualPrefab;
	public GameObject unitOnTile;
	public bool isWalkable = true;
	public float movementCost = 1;

}
