using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]

public class FirstPersonController : MonoBehaviour
{

	public float speed = 10.0f;
	public float gravity = 10.0f;
	public float maxVelocityChange = 10.0f;
	public bool canJump = true;
	public float jumpHeight = 2.0f;
	private bool grounded = false;
	private Rigidbody rigidbody;

	void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
		rigidbody.freezeRotation = true;
		rigidbody.useGravity = false;
	}

	private void Update()
	{
		
	}

	void FixedUpdate()
	{
		if (grounded)
		{
			// Calculate how fast we should be moving
			Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			targetVelocity = transform.TransformDirection(targetVelocity);
			targetVelocity *= speed;

			// Apply a force that attempts to reach our target velocity
			Vector3 velocity = rigidbody.velocity;
			Vector3 velocityChange = (targetVelocity - velocity);
			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
			velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
			velocityChange.y = 0;
			rigidbody.AddForce(velocityChange, ForceMode.VelocityChange);

			// Jump
			if (canJump && Input.GetButton("Jump"))
			{
				rigidbody.velocity = new Vector3(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
			}
		}
		Look();

		// We apply gravity manually for more tuning control
		rigidbody.AddForce(new Vector3(0, -gravity * rigidbody.mass, 0));

		grounded = false;
	}

	void OnCollisionStay()
	{
		grounded = true;
	}

	float CalculateJumpVerticalSpeed()
	{
		// From the jump height and gravity we deduce the upwards speed 
		// for the character to reach at the apex.
		return Mathf.Sqrt(2 * jumpHeight * gravity);
	}

	public float lookSpeed = 3;
	private Vector2 rotation = Vector2.zero;
	public void Look() // Look rotation (UP down is Camera) (Left right is Transform rotation)
	{
		rotation.y += Input.GetAxis("Mouse X");
		rotation.x += -Input.GetAxis("Mouse Y");
		rotation.x = Mathf.Clamp(rotation.x, -15f, 15f);
		transform.eulerAngles = new Vector2(0, rotation.y) * lookSpeed;
		Camera.main.transform.localRotation = Quaternion.Euler(rotation.x * lookSpeed, 0, 0);
	}
}