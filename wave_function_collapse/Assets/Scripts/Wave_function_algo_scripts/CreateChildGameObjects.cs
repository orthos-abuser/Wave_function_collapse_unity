using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateChildGameObjects : MonoBehaviour
{
    [Tooltip("how many child game objects to spawn")]
    [SerializeField] public static int childGameObjectsCount = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < childGameObjectsCount; i++)
        {
            GameObject go = new GameObject(i.ToString());
            go.transform.parent = transform;
            go.AddComponent<Mesh_combiner_script_call>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
