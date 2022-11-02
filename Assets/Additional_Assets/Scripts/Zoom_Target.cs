using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Zoom_Target : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;
    [SerializeField]
    private GameObject _sphere;
    
    private CinemachineVirtualCamera _cam;
    
    [SerializeField]
    private bool _lookingAtCube;

    

    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float FOV = _cam.m_Lens.FieldOfView -= 20;
            if (FOV < 20)
            {
                _cam.m_Lens.FieldOfView = 60;
            }
        }
    }

    private void SwitchTarget()
    {
        if (_lookingAtCube == false)
        {
            _cam.LookAt = _cube.transform;
            _lookingAtCube = true;
        }
        else if (_lookingAtCube == true)
        {
            _cam.LookAt = _sphere.transform;
            _lookingAtCube = false;
        }
    }


}
