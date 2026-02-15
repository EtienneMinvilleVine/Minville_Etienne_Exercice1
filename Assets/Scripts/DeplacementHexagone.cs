using UnityEngine;

public class DeplacementHexagone : MonoBehaviour
{
    //VITESSE DÉPLACEMENT
    public float vitesse = 0.01f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;

    //ROTATION
    public float vitesseRotation = 12f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, vitesse, 0, Space.World);

        transform.Rotate(0, 0, vitesseRotation * Time.deltaTime);

        if (transform.position.y > limiteHaut || transform.position.y < limiteBas)
        {
            float nouvellePositionX = transform.position.x;
            float nouvellePositionY = limiteBas;

            transform.position = new Vector2(nouvellePositionX, nouvellePositionY);

            vitesse = vitesse * -1;
        }
        
    }
}

