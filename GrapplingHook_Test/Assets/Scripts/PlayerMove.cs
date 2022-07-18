using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	[SerializeField]
	private float playerSpeed = 5.0f;

	[Header("Running")]
	[SerializeField] 
	private bool canRun = true;
	public bool IsRunning { get; private set; }
	[SerializeField]
	private float runSpeed = 10.0f;
	public KeyCode runningKey = KeyCode.LeftShift;

	private Rigidbody rigidbody;

	public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();

	// Start is called before the first frame update
	void Awake()
	{
		//	このスクリプトのアタッチされているオブジェクトのRigidbodyを取得する
		rigidbody = this.gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	private void FixedUpdate()
	{

	}
}
