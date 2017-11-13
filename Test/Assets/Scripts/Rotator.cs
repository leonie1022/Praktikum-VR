using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Rotator : NetworkBehaviour 
{
	private Collider objCollider;
	// Update is called once per frame

	void start()
	{
		objCollider = GetComponent<Collider> ();

	}
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "PickUp") {
			CmdDestroy (other.gameObject);
		}
	}
	void CmdDestroy(GameObject obj){
		NetworkServer.Destroy (obj);
	}
}
