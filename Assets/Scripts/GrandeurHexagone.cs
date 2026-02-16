using UnityEngine;

public class GrandeurHexagone : MonoBehaviour
{

    public float vitesse = 0.01f;

    public float reduction = 0.001f;

    public float tailleInitiale = 3f;
    
    public bool peutBouger = true;

    public bool hexagoneCroissance = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (peutBouger == true)
        {
            float nouvelleTaille = transform.localScale.x;
            float change = reduction * vitesse;

            if (!hexagoneCroissance)
            {
                nouvelleTaille -= change;
                if (nouvelleTaille <= 0f)
                {
                   nouvelleTaille = 0f;
                   hexagoneCroissance = true; 
                }
            }

            else
            {
                nouvelleTaille += change;
                if (nouvelleTaille >= tailleInitiale)
                {
                    nouvelleTaille = tailleInitiale;
                    hexagoneCroissance = false;
                }
            }

            transform.localScale = new Vector3(nouvelleTaille, nouvelleTaille, nouvelleTaille);
        }
    }
}
