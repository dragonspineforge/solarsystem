using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLookAMainCamera : MonoBehaviour
{
    public Camera m_Camera;
	public float objectScale = 1.0f;
	private Vector3 initialScale;

	// set the initial scale, and setup reference camera
	void Start()
	{
		// record initial scale, use this as a basis
		initialScale = transform.localScale;

		// if no specific camera, grab the default camera
		if (m_Camera == null)
			m_Camera = Camera.main;
	}


	void LateUpdate()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward, m_Camera.transform.rotation * Vector3.up);
    }

	// scale object relative to distance from camera plane
	void Update()
	{
		Plane plane = new Plane(m_Camera.transform.forward, m_Camera.transform.position);
		float dist = plane.GetDistanceToPoint(transform.position);
		transform.localScale = initialScale * dist * objectScale;
	}
}
