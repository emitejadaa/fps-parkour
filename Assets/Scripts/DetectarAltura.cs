using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectarAltura : MonoBehaviour
{
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje.transform.position.y <= -10)
        {
            Debug.Log("aaa");
            SceneManager.LoadScene("fps parkour");
        }
    }
}
