using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody2D rb2d;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();

	}

	// Movement of player
	void FixedUpdate () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveH, moveV);
		rb2d.AddForce (movement * speed);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
