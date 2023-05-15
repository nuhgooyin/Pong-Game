using UnityEngine;
using System.Collections;

public class MenuBall : MonoBehaviour
{
	public float ballVelocity = 700;

	Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();

		rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
	}
}