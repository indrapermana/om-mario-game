using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
	public Transform player;
	public Transform Bg1;
	public Transform Bg2;
	public Transform Bg3;
	public Transform Bg4;
	public Transform Bg5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.x != transform.position.x && player.position.x > 0 && player.position.x < 12f)
		{
			transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, transform.position.y, transform.position.z), 0.1f);
		}
		Bg1.transform.position = new Vector2(transform.position.x * 1.0f, Bg1.transform.position.y);
		Bg2.transform.position = new Vector2(transform.position.x * 0.8f, Bg2.transform.position.y);
		Bg3.transform.position = new Vector2(transform.position.x * 0.6f, Bg3.transform.position.y);
		Bg4.transform.position = new Vector2(transform.position.x * 0.4f, Bg4.transform.position.y);
		Bg5.transform.position = new Vector2(transform.position.x * 0.2f, Bg5.transform.position.y);
	}
}
