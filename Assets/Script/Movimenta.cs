using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimenta : MonoBehaviour
{
    [SerializeField] float velocity = 5.0f;

    void movimento()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x, y, 0) * velocity * Time.deltaTime);
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movimento();
    }
}
