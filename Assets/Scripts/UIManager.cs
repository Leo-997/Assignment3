using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        SceneManager.LoadScene(1);
    }
    public void BackToStart()
    {
        SceneManager.LoadScene(1);
    }




}
