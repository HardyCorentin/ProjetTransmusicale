using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSCENE : MonoBehaviour
{

    public string nextSceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
