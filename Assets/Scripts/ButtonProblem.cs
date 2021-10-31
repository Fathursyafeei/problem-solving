using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonProblem : MonoBehaviour
{
    [SerializeField] private Button bt1;
    [SerializeField] private Button bt2;
    [SerializeField] private Button bt3;
    [SerializeField] private Button bt4;
    [SerializeField] private Button bt5;
    [SerializeField] private Button bt6;
    [SerializeField] private Button bt7;
    [SerializeField] private Button bt8;
    [SerializeField] private Button bt9;

    // Start is called before the first frame update
    void Start()
    {
        bt1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        bt2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        bt3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        bt4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        bt5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        bt6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        bt7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        bt8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        bt9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }

    
}
