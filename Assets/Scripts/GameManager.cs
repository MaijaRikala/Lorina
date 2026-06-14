using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Class variables -----------------------------------------------

    // Static private variable to hold the reference
    public static GameManager Instance { get; private set; }


    [Header("UI Panels")]
    public GameObject pausePanel;
    public GameObject settingsPanel;
    public GameObject mainMenuPanel;
    public GameObject cutscenePanel;
    public GameObject cauldronPanel;
    public GameObject greenhousePanel;
    public GameObject spiceCabinetPanel;
    public GameObject cellarPanel;
    public GameObject stirPanel;
    public GameObject heatingPanel;



    // Initialize ----------------------------------------------------

    // Initialize variables
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


    // Main menu functions -----------------------------------------------


    // --- Open cutscene panel ---
    public void OpenCutscene()
    {
        if (cutscenePanel != null)
            cutscenePanel.SetActive(true);
        // No need to close this, since the next step is to load main game scene
    }


    // --- Open Settings panel ---
    public void OpenSettings()
    {
        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(false);

        if (settingsPanel != null)
            settingsPanel.SetActive(true);
    }


    // --- Close Settings panel ---
    public void CloseSettings()
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(false);

        if (mainMenuPanel != null)
            mainMenuPanel.SetActive(true);
    }


    // Main game functions ----------------------------------------------


    // --- Go back to Main Menu ---
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }


    // --- Open cauldron panel ---
    public void OpenCauldronPanel()
    {
        if (cauldronPanel != null)
            cauldronPanel.SetActive(true);
    }

    // --- Close cauldron panel ---
    public void CloseCauldronPanel()
    {
        if (cauldronPanel != null)
            cauldronPanel.SetActive(false);
    }


    // --- Open greenhouse panel ---
    public void OpenGreenhousePanel()
    {
        if (greenhousePanel != null)
            greenhousePanel.SetActive(true);
    }

    // --- Close greenhouse panel ---
    public void CloseGreenhousePanel()
    {
        if (greenhousePanel != null)
            greenhousePanel.SetActive(false);
    }


    // --- Open cellar panel ---
    public void OpenCellarPanel()
    {
        if (cellarPanel != null)
            cellarPanel.SetActive(true);
    }

    // --- Close cellar panel ---
    public void CloseCellarPanel()
    {
        if (cellarPanel != null)
            cellarPanel.SetActive(false);
    }


    // --- Open spice cabinet panel ---
    public void OpenSpiceCabinetPanel()
    {
        if (spiceCabinetPanel != null)
            spiceCabinetPanel.SetActive(true);
    }

    // --- Close spice cabinet panel ---
    public void CloseSpiceCabinetPanel()
    {
        if (spiceCabinetPanel != null)
            spiceCabinetPanel.SetActive(false);
    }


    // --- Open stir options panel ---
    public void OpenStirPanel()
    {
        if (stirPanel != null)
            stirPanel.SetActive(true);
    }

    // --- Close stir options panel ---
    public void CloseStirPanel()
    {
        if (stirPanel != null)
            stirPanel.SetActive(false);
    }


    // --- Open heating options panel ---
    public void OpenHeatingPanel()
    {
        if (heatingPanel != null)
            heatingPanel.SetActive(true);
    }

    // --- Close hating options panel ---
    public void CloseHeatingPanel()
    {
        if (heatingPanel != null)
            heatingPanel.SetActive(false);
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
