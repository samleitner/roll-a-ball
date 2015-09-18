using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	//private because value set in script
	/*value set taken by subtracting current transform 
	pos. of camera by transform pos. of player
	*/

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	//know absolutely player has moved on frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
