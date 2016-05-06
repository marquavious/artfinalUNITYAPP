using UnityEngine;
using System.Collections;

public class morespin : MonoBehaviour {

    public float speeda = -6f;



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speeda * Time.deltaTime);

    }
}
