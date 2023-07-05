using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * 5;
        float v = Input.GetAxisRaw("Vertical") * 5;
        _transform.Translate(new Vector3(h * Time.deltaTime, v * Time.deltaTime, 0));
    }
}
