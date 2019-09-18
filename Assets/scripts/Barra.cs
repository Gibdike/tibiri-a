using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    public Image imagemBarra;

    public int progresso;
    
    void Start() {
       imagemBarra.fillAmount= 0;
   }
    public void progressao(){
        imagemBarra.fillAmount += 0.01f * progresso;
    }
}
