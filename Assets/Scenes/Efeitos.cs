using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Efeitos : MonoBehaviour
{
    public Image[] imagens = new Image[7];
   

    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EfeitosUI(Image imagem){
        imagens[contador].sprite = imagem.sprite;
        contador++;
        
    }
}
