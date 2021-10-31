using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
    [SerializeField] private Button btnQuit;
    [SerializeField] private Button btnPlay;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
        btnQuit.onClick.AddListener(() =>
        {
            #if !UNITY_EDITOR
			            Application.Quit();
            #endif

            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #endif
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
