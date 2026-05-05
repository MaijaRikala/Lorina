using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Class variables -----------------------------------------------

    // Static private variable to hold the reference
    public static GameManager Instance { get; private set; }


    [Header("UI Panels")]
    public GameObject pausePanel;
    public GameObject optionsPanel;
    public GameObject mainMenuPanel;
    public GameObject cauldronPanel;
    public GameObject greenhousePanel;
    public GameObject spiceCabinetPanel;
    public GameObject cellarPanel;



    // Initialize ----------------------------------------------------

    // Initialize variables, in this case only _instance
    // Set _instance reference as soon as possible
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }


    // Handle destroying GameManager
    void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }



    // Scene control -------------------------------------------------


    // --- Load Game scene ---
    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainGame");
    }


    // --- Restart Scene ---
    public void RestartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    // --- Pause the game ---
    public void PauseGame()
    {
        Time.timeScale = 0f;

        if (pausePanel != null)
            pausePanel.SetActive(true);
    }

    // --- Resume the game ---
    public void ResumeGame()
    {
        Time.timeScale = 1f;

        if (pausePanel != null)
            pausePanel.SetActive(false);
    }


    // --- Open Options panel ---
    public void OpenOptions()
    {
        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(false);

        if (optionsPanel != null)
            optionsPanel.SetActive(true);
    }


    // --- Close Options panel ---
    public void CloseOptions()
    {
        if (optionsPanel != null)
            optionsPanel.SetActive(false);

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);
    }


    // --- Go back to Main Menu ---
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }


    // --- Open cauldron panel ---
    public void OpenCauldronPanel ()
    {
        if (cauldronPanel != null)
            cauldronPanel.SetActive(true);
    }

    // --- Close cauldron panel ---
    public void CloseCauldronPanel ()
    {
        if (cauldronPanel != null)
            cauldronPanel.SetActive(false);
    }


    // --- Quit game ---

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit pressed");
    }



    // -----------------------------------------------------------------------

    private void Update()
    {
        // ESC pauses or resumes the game
        if (Input.GetKeyDown(KeyCode.Escape) && pausePanel != null)
        {
            if (pausePanel.activeSelf)
                ResumeGame();
            else
                PauseGame();
        }
    }

}
