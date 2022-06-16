using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1GamaManager : MonoBehaviour
{
    [SerializeField]
    private GameObject addTimePanel = null;

    [SerializeField]
    private GameObject test = null;

    [SerializeField]
    private GameObject deletePanel = null;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scne2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPopup()
    {
        Debug.Log("openPopup");
        if(addTimePanel.activeSelf == true)
        {

        }
        else
        {
            addTimePanel.SetActive(true);
        }
    }
    public void closePopup()
    {
        if (addTimePanel.activeSelf == true)
        {
            test.SetActive(true);
            addTimePanel.SetActive(false);
        }
    }

    public void deleteItem()
    {
        deletePanel.SetActive(false);
    }
}
