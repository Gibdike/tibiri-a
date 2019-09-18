using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComprarAlgas : MonoBehaviour
{
    public GameObject[] imagensPlanta = new GameObject[4];
    public GameObject[] imagensPlantaFixada = new GameObject[4];
    int contador = 0;
    int contadorFixar = 0;
    int flag;
    public int quantidadesdeAlgas;
            // Start is called before the first frame update
   public void ComprarPlanta(){
       imagensPlanta[contador].SetActive(true);
       contador++; 
       quantidadesdeAlgas++;
       
   }
   public void FixarPlantas(){ 
            if (  contadorFixar < quantidadesdeAlgas){
                print(contadorFixar);
                if (flag == 1){
                    imagensPlanta[contadorFixar].SetActive(false);
                    imagensPlantaFixada[contadorFixar].SetActive(true);
                    contadorFixar++;
                }
                flag++;
            }
            else
            {
                print("aqui");
            }

   }

    
}
