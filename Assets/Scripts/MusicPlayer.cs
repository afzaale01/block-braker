using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer Instace;
    // Start is called before the first frame update
    void Start()
    {
        if (Instace != null)
        {
            Destroy(Instace);
        }
        else {
            Instace = this;
            //GameObject.DontDestroyOnLoad(gameObject);
        }

        //print(GetInstanceID());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
