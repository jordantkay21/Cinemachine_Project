using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switch : MonoBehaviour
{

    private GameObject _centerCam, _frontRightCam, _frontLeftCam;
    // Start is called before the first frame update
    void Start()
    {
        _centerCam = GameObject.Find("Center");
        _frontRightCam = GameObject.Find("Front_Right");
        _frontLeftCam = GameObject.Find("Front_Left");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _frontRightCam.SetActive(true);
            _centerCam.SetActive(false);
            _frontLeftCam.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            _frontLeftCam.SetActive(true);
            _centerCam.SetActive(false);
            _frontRightCam.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _centerCam.SetActive(true);
            _frontLeftCam.SetActive(false);
            _frontRightCam.SetActive(false);

        }
    }
}
