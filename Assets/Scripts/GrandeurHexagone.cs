using UnityEngine;

public class GrandeurHexagone : MonoBehaviour
{

    public float vitesse = 0.01f;

    public float reduction = 0.001f;

    public bool peutBouger = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (peutBouger == true)
        {
            float nouvelleTaille = transform.localScale.x - reduction;

            transform.localScale = new Vector3(nouvelleTaille, nouvelleTaille, nouvelleTaille);

            if (transform.localScale.x <= 0)
            {
                peutBouger = false;
            }
            if (peutBouger == false)
            {
                
            }
        }
    }
}
