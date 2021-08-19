using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				pauseMenu.SetActive(false);
				this.GetComponent<AudioSource>().UnPause();
				Cursor.visible = false;
				gamePaused = false;
				Time.timeScale = 1;
			}
		}
	}

	public void ResumeGame()
    {
		pauseMenu.SetActive(false);
		this.GetComponent<AudioSource>().UnPause();
		Cursor.visible = false;
		gamePaused = false;
		Time.timeScale = 1;
	}

	public void RestartGame()
    {
		GlobalCoins.coinCount = 0;
		Time.timeScale = 1;
		SceneManager.LoadScene(1);
	}
}
