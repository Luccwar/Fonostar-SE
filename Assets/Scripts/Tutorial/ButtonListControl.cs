using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonListControl : MonoBehaviour
{
    [SerializeField]
    private GameObject letraTemplate;

    [SerializeField]
    private string[] stringArray;

    private List<GameObject> letras;
    private GameObject selecaoCanvas;
    private GameObject faseCanvas;
    private GameObject faseImage;

    private void Start() {
        selecaoCanvas = GameObject.Find("SelecaoCanvas");
        faseCanvas = GameObject.Find("FaseCanvas");
        faseImage = GameObject.Find("FaseImage");
        faseCanvas.SetActive(false);
        GenerateList();
    }

    void GenerateList() {
        letras = new List<GameObject>();
        if (GetComponentInChildren<ButtonListButton>() != null)
        {
            ButtonListButton[] BLB = GetComponentsInChildren<ButtonListButton>();
            foreach (ButtonListButton i in BLB)
            {
                Destroy(i.gameObject);
            }
        }


        foreach (string i in stringArray)
        {
            GameObject letra = Instantiate(letraTemplate) as GameObject;
            Button[] fases;
            letra.SetActive(true);

            letra.GetComponent<TextMeshProUGUI>().SetText(i);

            fases = letra.GetComponentsInChildren<Button>();
            
            for (int x=0;x<fases.Length;x++)
            {
                int y = x;
                fases[x].onClick.AddListener(delegate{AparecerCaixa("Fase " + i + y);});
                //fases[x].onClick.AddListener(delegate{TrocarCena("Fase " + i + y);});
                
                //fases[x].onClick.AddListener(() => { TrocarCena("Fase " + i + x); });
            }

            //letra.GetComponent<ButtonListButton>().SetText(i);

            letra.transform.SetParent(letraTemplate.transform.parent, false);
        }
    }

    public void ButtonClicked()
    {
        Debug.Log("Clicastes");
    }

    void TrocarCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    void AparecerCaixa(string fase)
    {
        selecaoCanvas.SetActive(false);
        faseCanvas.SetActive(true);
        faseImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + fase);
    }

    public void RetornarSelecao()
    {
        faseCanvas.SetActive(false);
        selecaoCanvas.SetActive(true);
        GenerateList();
    }


}
