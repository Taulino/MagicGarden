using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
    }
    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}