using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    public GameObject player;
    public GameObject[] objetos;
    public GameObject UIMenu;
    public Text texto;
    public Text txtItensCount;
    public int itensCount = 0;
    public int qtdTotalItens = 3;
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (itensCount >= qtdTotalItens)
        {
            print("Fim Jogo");
        }       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "objeto")
        {
            // print("Dentro da area");
            if (Input.GetButtonDown("Fire1"))
            {
                //texto.text("fd");
                itensCount++;
                txtItensCount.text = "Intens: " + itensCount;
                texto.text = "Coletou um Obejto";
                print("Interagiu");
                Destroy(other.gameObject);
                StartCoroutine(TempoTxt());                
            }

        }
    }
    public void Iniciar()
    {
        UIMenu.SetActive(false);
    }
    IEnumerator TempoTxt()
    {
        yield return new WaitForSeconds(3);
        texto.text = "";
    }

    public void EscolherPersonagem()
    {
        new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
    }
    public void Reiniciar()
    {
        //print("Reiniciar");
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
}
