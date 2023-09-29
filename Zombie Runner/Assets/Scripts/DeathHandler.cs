using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas GameOverCanvas;
	void Start()
    {
		GameOverCanvas.enabled = false;
    }

    public void HandleDeath()
    {
        GameOverCanvas.enabled = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        Cursor.visible = true;
    }
}
