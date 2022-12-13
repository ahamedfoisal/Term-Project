using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void scence_changer(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
