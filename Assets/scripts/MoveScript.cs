using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	/// <summary>
	/// The speed of the player
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);

	/// <summary>
	/// Enemy moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);

	// Store the movement and the component
	private Vector2 movement;
	private Rigidbody2D rigidbodyComponent;

	// Update is called once per frame
	void Update () {

		// Movement per direction
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y
		);
	}

	void FixedUpdate() {
		// Get the component and store the reference
		if (rigidbodyComponent == null) {
				rigidbodyComponent = GetComponent<Rigidbody2D>();
		}

    // Move the game object
		rigidbodyComponent.velocity = movement;
	}
}
