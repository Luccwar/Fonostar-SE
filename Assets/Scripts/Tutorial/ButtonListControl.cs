using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonListControl : MonoBehaviour
{
    private VoiceController VC;
    public AudioSource AS;
    [SerializeField]
    private GameObject letraTemplate;
    private List<GameObject> letras;
    private GameObject selecaoCanvas;
    private GameObject faseCanvas;
    private GameObject palavraTexto;
    private GameObject faseImage;
    private GameObject botaoOuvir;

    private void Start() {
        VC = FindObjectOfType(typeof(VoiceController)) as VoiceController;
        selecaoCanvas = GameObject.Find("SelecaoCanvas");
        faseCanvas = GameObject.Find("FaseCanvas");
        palavraTexto = GameObject.Find("PalavraTexto");
        faseImage = GameObject.Find("FaseImage");
        botaoOuvir = GameObject.Find("BotaoOuvir");
        faseCanvas.SetActive(false);
        GenerateList();
    }

    void GenerateList() {
        letras = new List<GameObject>();
        if (GetComponentInChildren<ButtonListButton>() != null)
        {
            ButtonListButton[] BLB = GetComponentsInChildren<ButtonListButton>();
            foreach (ButtonListButton l in BLB)
            {
                Destroy(l.gameObject);
            }
        }


        foreach (Letra l in InfoPronuncia.letras)
        {
            GameObject letra = Instantiate(letraTemplate) as GameObject;
            Button[] fases;
            letra.SetActive(true);

            letra.GetComponent<TextMeshProUGUI>().SetText(l.nome);

            fases = letra.GetComponentsInChildren<Button>();
            
            for (int x=0;x<fases.Length;x++)
            {
                int y = x;
                fases[x].onClick.AddListener(delegate{AparecerCaixa(l.palavras[y]);});
                fases[x].GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + l.palavras[y].imagemPalavra);
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

    void TocarAudio(AudioClip audio)
    {
        AS.clip = audio;
        AS.Play();
    }

    void AparecerCaixa(Palavra palavra)
    {
        selecaoCanvas.SetActive(false);
        faseCanvas.SetActive(true);
        faseImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + palavra.imagemPalavra);
        palavraTexto.GetComponent<TextMeshProUGUI>().text = palavra.nome;
        botaoOuvir.GetComponent<Button>().onClick.AddListener(delegate{TocarAudio(Resources.Load<AudioClip>("Audio/" + palavra.somFalado));});
        PlayerPrefs.SetString("PalavraDesejada", palavra.nome);
    }

    public void RetornarSelecao()
    {
        faseCanvas.SetActive(false);
        selecaoCanvas.SetActive(true);
        GenerateList();
    }


}
