using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Camera chaseCam;
	public Transform target; // the object to rotate around
	public int speed; // the speed of rotation
	
	void Start() {
		if (target == null) 
		{
			target = this.gameObject.transform;
			Debug.Log ("RotateAround target not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update () {
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(target.transform.position,target.transform.up,speed * -1 * Time.deltaTime);

		if (chaseCam != null)
		{
			//counteract planet rotations effect on the chase camera
			chaseCam.transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
		}
	}
}
