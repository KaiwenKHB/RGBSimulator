using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public int sceneIndex;
    public void loadScene()
    {
        EditorSceneManager.LoadScene(sceneIndex);
    }
}
