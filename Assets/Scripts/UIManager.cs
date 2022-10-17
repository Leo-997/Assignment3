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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //Scene Sample = SceneManager.GetSceneByName("SampleScene");
        //if (Sample.isLoaded == true)
        //{
        //    Button but = GameObject.FindGameObjectWithTag("Exit").GetComponent<Button>();
        //    but.onClick.AddListener(QuitGame);
        //}
    }

}
