using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField, Range(0.0f, 100.0f)]
	float maxSpeed;
	[SerializeField, Range(0.0f, 20.0f)]
	float powerAmount;
	
	[Space]

	[Header("KeyCode")]
	[SerializeField] KeyCode m_Forward;
	[SerializeField] KeyCode m_Back;
	[SerializeField] KeyCode m_Left;
	[SerializeField] KeyCode m_Right;


	private Rigidbody m_rb;

	// Start is called before the first frame update
	void Awake()
	{
		m_rb = this.transform.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	private void FixedUpdate()
	{
		if (Input.GetKeyDown(m_Forward))
		{
			if (m_rb.velocity.magnitude < maxSpeed)
				m_rb.AddForce(0,0,powerAmount,ForceMode.Acceleration);
		}
	}
}
