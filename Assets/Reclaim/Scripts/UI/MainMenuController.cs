using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


public class MainMenuController : MonoBehaviour
{
    [SerializeField] public VisualElement m_uxml;

    [SerializeField] private Button m_startButton;
    [SerializeField] private Button m_settingsButton;
    [SerializeField] private Button m_quitButton;


    void OnEnable()
    {
        m_uxml = GetComponent<UIDocument>().rootVisualElement;

        m_startButton = m_uxml.Q<Button>("Start-Button");
        m_startButton.clicked += OnStartButtonClicked;

        m_settingsButton = m_uxml.Q<Button>("Settings-Button");
        m_settingsButton.clicked += OnSettingsButtonClicked;

        m_quitButton = m_uxml.Q<Button>("End-Button");
        m_quitButton.clicked += OnEndButtonClicked;
    }

    void OnDisable()
    {

        m_startButton.clicked -= OnStartButtonClicked;
        m_settingsButton.clicked -= OnSettingsButtonClicked;
        m_quitButton.clicked -= OnEndButtonClicked;
    }

    private void OnEndButtonClicked()
    {
        Application.Quit();
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }

    private void OnSettingsButtonClicked()
    {
        Debug.Log("Setting Button MainMenu Clicked!");
    }

    private void OnStartButtonClicked()
    {
        gameObject.SetActive(false);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
