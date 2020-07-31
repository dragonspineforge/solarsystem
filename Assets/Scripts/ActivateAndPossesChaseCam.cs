using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndPossesChaseCam : MonoBehaviour
{   
    public Camera chaseCam;
    public Camera overviewCamera;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(overviewCamera.ScreenToWorldPoint(Input.mousePosition), transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.name == "Jupiter" && gameObject.name.Contains("Jupiter"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Saturn" && gameObject.name.Contains("Saturn"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Pluto" && gameObject.name.Contains("Pluto"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Uranus" && gameObject.name.Contains("Uranus"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Neptune" && gameObject.name.Contains("Neptune"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Mars" && gameObject.name.Contains("Mars"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Earth" && gameObject.name.Contains("Earth"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Venus" && gameObject.name.Contains("Venus"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Mercury" && gameObject.name.Contains("Mercury"))
                {
                    chaseCam.enabled = true;
                    overviewCamera.enabled = false;

                    Camera.SetupCurrent(chaseCam);
                    this.GetComponent<SpriteRenderer>().enabled = false;
                }
            }

            //RaycastHit2D hit = Physics2D.Raycast(overviewCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.down, Mathf.Infinity);

            //if (hit.collider != null)
            //{
            //    Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
            //    this.GetComponent<SpriteRenderer>().enabled = false;
            //}
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            chaseCam.enabled = false;
            overviewCamera.enabled = true;

            Camera.SetupCurrent(overviewCamera);
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    
}
