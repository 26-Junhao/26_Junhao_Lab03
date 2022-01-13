using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("GamePlay_Level 1");
    }
}
