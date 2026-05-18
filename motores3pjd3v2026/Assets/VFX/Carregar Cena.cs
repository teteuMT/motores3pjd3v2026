using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Carrega uma cena pelo nome
    public void LoadScene(string sceneName)
    {
        GameManager.Instance.LoadScene(sceneName);
    }

    // Carrega uma cena pelo índice do Build Settings
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Reinicia a cena atual
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Volta para o menu principal
    public void LoadMainMenu()
    {
        GameManager.Instance.LoadScene("MenuPrincipal");
    }

    // Carrega a cena de gameplay
    public void LoadGameplay()
    {
        GameManager.Instance.LoadScene("GetStarted_Scene");
    }

    // Sai do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
