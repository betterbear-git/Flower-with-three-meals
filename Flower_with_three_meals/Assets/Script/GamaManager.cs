using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToScne1()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void moveToScne2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void moveToScne3()
    {
        SceneManager.LoadScene("Scene 3");
    }
    public void moveToScne4()
    {
        SceneManager.LoadScene("Scene4");
    }
}
