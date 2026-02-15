using UnityEngine;

public class RotationCarre : MonoBehaviour
{

    public float vitesseRotation = 0.03f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(0, 0, vitesseRotation); 
    }
}
