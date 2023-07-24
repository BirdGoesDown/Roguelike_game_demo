using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEntrance : MonoBehaviour
{
    public string lastExitName;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("LastExitName") == lastExitName)
        {
            //PlayerMovement.instance.transform.position = transform.position;
            PlayerMovement.instance.transform.position = new Vector3(0, 0, 0);
            //PlayerMovement.instance.transform.eulerAngles = transform.eulerAngles;
        }
    }
}
