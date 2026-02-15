using UnityEngine;

public class DeplacementHexagone : MonoBehaviour
{

    public float vitesseX = 0.1f;

    public float vitesseY = 0.1f;

    public float tauxReduction = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesseX, vitesseY, 0);
    }
}
