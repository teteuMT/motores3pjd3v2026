using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player Input")]
    [SerializeField] private PlayerInput playerInput;

    public NewMonoBehaviourScript.GameState CurrentState { get; private set; }

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        ChangeState(NewMonoBehaviourScript.GameState.Iniciando);
    }

    private void Start()
    {
        LoadScene("Splash");
    }

    // Mudança de estado
    public void ChangeState(NewMonoBehaviourScript.GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado atual: " + CurrentState);
    }

    // Controle centralizado de cenas
    public void LoadScene(string sceneName)
    {
        switch (sceneName)
        {
            case "_Boot":
                ChangeState(NewMonoBehaviourScript.GameState.Iniciando);
                break;

            case "Splash":
                ChangeState(NewMonoBehaviourScript.GameState.Splash);
                break;

            case "MenuPrincipal":
                ChangeState(NewMonoBehaviourScript.GameState.MenuPrincipal);
                break;

            case "GetStarted_Scene":
                ChangeState(NewMonoBehaviourScript.GameState.Gameplay);
                break;
        }

        SceneManager.LoadScene(sceneName);
    }

    // Alocação de input
    public void AssignPlayerInput(PlayerInput input)
    {
        playerInput = input;

        if (playerInput != null)
        {
            Debug.Log("Player Input conectado!");
        }
    }

    // Sair do jogo
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}