using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    private void Start()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //add MainManager.instance.SaveScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit()
#endif
    }
}
