using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fala : MonoBehaviour {
    public GameObject balao;
    //variaveis controladoras
    public int cont=0;
    public int pas=1;
    //pega o objeto clone criado para desaparecer
    public GameObject inst;
    //balões
    public GameObject[] mud = new GameObject[2];
    //eu ia usar para verificar quando estivesse okay mas ñ sei oq é para fazer
    public int quantidadebaloes=2;
    //multiplicador para alterar sprite
    public int auxquantbaloes=1;

    void OnMouseDown(){
        //variaveis controladoras
        this.cont+=1;
        this.pas+=1;
        //chama função para alterar sprite
        mudarq(this.cont);
        if(this.pas==1){
            //inicia balão //new Vector3(5, 1) define posição
            this.inst = Instantiate(this.balao, new Vector3(5, 1), Quaternion.identity);
        }else{
            //tchau balão
            Destroy(this.inst);
     
             
        }
    }
    void mudarq(int con){
        //preguiça de entender oq eu fiz mas é isso ai
        if(con==(2*this.auxquantbaloes)+1){
            this.balao=this.mud[auxquantbaloes-1];
            this.auxquantbaloes+=1;
            //sempre voltar pas para 1 para inilicializar balão
            this.pas=1;
        }
    }
}