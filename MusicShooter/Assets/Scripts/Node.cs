using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("MouseDown on node " + this.gameObject.name);
    }

    public void OnEnd()
    {
        Destroy(this.transform.root.gameObject);
    }
}
