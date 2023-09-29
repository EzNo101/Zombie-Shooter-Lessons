using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 30f;
    [SerializeField] float zoomOutSensitivity = 2f;
	[SerializeField] float zoomInSensitivity = .5f;

	RigidbodyFirstPersonController fpsController;

	bool zoomedIntToggle;

	private void Start()
	{
		fpsController = GetComponent<RigidbodyFirstPersonController>();
	}

	void Update()
    {
        Zoom();
	}

    void Zoom()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
			if(zoomedIntToggle == false)
            {
                zoomedIntToggle = true;
                fpsCamera.fieldOfView = zoomInFOV;
                fpsController.mouseLook.XSensitivity = zoomInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomInSensitivity;
                
            }
            else if(zoomedIntToggle == true)
            {
				zoomedIntToggle = false;
				fpsCamera.fieldOfView = zoomOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
				fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
			}
        }
    }
}
