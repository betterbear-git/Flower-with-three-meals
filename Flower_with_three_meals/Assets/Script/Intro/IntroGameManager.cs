using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("start");
        StartCoroutine(CountAttackDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountAttackDelay()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Scene1");
    }
}
