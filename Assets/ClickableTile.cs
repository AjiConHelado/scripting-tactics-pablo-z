using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ClickableTile : MonoBehaviour {

	public int tileX;
	public int tileY;
	public TileMap map;
	public GameObject unitOnTile;

	/*void OnMouseUp() {
		Debug.Log ("Click!");

		if(EventSystem.current.IsPointerOverGameObject())
			return;

		map.GeneratePathTo(tileX, tileY);
	}*/

}
