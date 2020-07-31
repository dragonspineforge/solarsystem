using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour
{
    public Camera overviewCamera;
    public Text buttonText;

    public void OnInnerSolarSystemClick()
    {
        if (overviewCamera.orthographicSize != 280)
        {
            overviewCamera.orthographicSize = 280;
            buttonText.text = "Outer Solar System View";
        }
        else
        {
            overviewCamera.orthographicSize = 7000;
            buttonText.text = "Inner Solar System View";
        }
    }

    public void OnWelcomTextClick(GameObject panel)
    {
        panel.SetActive(false);
    }
}
