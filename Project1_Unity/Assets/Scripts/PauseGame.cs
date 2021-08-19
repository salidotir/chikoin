using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	public bool gamePaused = false;
	public GameObject pauseMenu;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Cancel"))
        {
			if (gamePaused == false)
            {
				Time.timeScale = 0;         // stop time
				gamePaused = true;
				Cursor.visible = true;							// make the mouse cursor visible
				this.GetComponent<AudioSource>().Pause();		// stop music
				pauseMenu.SetActive(true);
            }

			else
            {
				pauseMenu.SetActive(true);
				this.GetComponent<AudioSource>().UnPause();
				Cursor.visible = false;
				gamePaused = false;
				Time.timeScale = 1;
			}
		}
	}
}
