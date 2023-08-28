using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    private GameObject canvasMenu;
    private GameObject canvasCreditos;
    private GameObject canvasApagarDados;
    private GameObject panelExibicao;
    private GameObject buttonCreditos;
    private GameObject buttonExibicao;
    private GameObject buttonRetornar;
    private GameObject buttonApagarCanvas;
    private GameObject buttonPronuncia;
    private GameObject buttonInventario;
    private GameObject buttonLoja;
    private GameObject buttonApagarDados;
    private GameObject buttonDarLetras;
    // Start is called before the first frame update
    void Start()
    {
        canvasMenu = GameObject.Find("CanvasMenu");
        canvasCreditos = GameObject.Find("CanvasCreditos");
        canvasApagarDados = GameObject.Find("CanvasApagarDados");
        panelExibicao = GameObject.Find("PanelExibicao");
        buttonCreditos = GameObject.Find("ButtonCreditos");
        buttonCreditos.GetComponent<Button>().onClick.AddListener(delegate{CanvasCreditos();});
        buttonExibicao = GameObject.Find("ButtonExibicao");
        buttonExibicao.GetComponent<Button>().onClick.AddListener(delegate{PanelExibicao();});
        buttonApagarCanvas = GameObject.Find("ButtonApagarCanvas");
        buttonApagarCanvas.GetComponent<Button>().onClick.AddListener(delegate{CanvasApagarDados();});
        buttonRetornar = GameObject.Find("ButtonRetornar");
        buttonRetornar.GetComponent<Button>().onClick.AddListener(delegate{CanvasMenu();});
        buttonRetornar = GameObject.Find("ButtonRetornar2");
        buttonRetornar.GetComponent<Button>().onClick.AddListener(delegate{CanvasMenu();});
        buttonPronuncia = GameObject.Find("ButtonPronuncia");
        buttonPronuncia.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("ListaLetra");});
        // buttonInventario = GameObject.Find("ButtonInventario");
        // buttonInventario.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("InventarioLetra");});
        // buttonLoja = GameObject.Find("ButtonLoja");
        // buttonLoja.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("LojaPalavra");});
        buttonApagarDados = GameObject.Find("ButtonApagarDados");
        buttonApagarDados.GetComponent<Button>().onClick.AddListener(delegate{ApagarDados();});

        buttonDarLetras = GameObject.Find("ButtonDarLetras");
        if(buttonDarLetras != null)
            buttonDarLetras.GetComponent<Button>().onClick.AddListener(delegate{DarLetras();});

        panelExibicao.GetComponentInChildren<Button>().onClick.RemoveAllListeners();
        panelExibicao.GetComponentInChildren<Button>().onClick.AddListener(delegate{FecharPanelExibicao();});
        //panelExibicao.transform.Find("FundoBranco").transform.Find("FundoCinza").transform.Find("ButtonFechar").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
        //panelExibicao.transform.Find("FundoBranco").transform.Find("FundoCinza").transform.Find("ButtonFechar").GetComponentInChildren<Button>().onClick.AddListener(delegate{FecharPanelExibicao();});
        if(PlayerPrefs.HasKey("PremioExibido"))
        {
            foreach (PalavraLoja pl in InfoPronuncia.palavraLojas) {
                if (pl.nomePremio == PlayerPrefs.GetString("PremioExibido")) {
                    buttonExibicao.GetComponent<Button>().interactable = true;
                    buttonExibicao.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Loja Icons/" + pl.imagemPremio);
                }
            }
        }
        canvasMenu.SetActive(true);
        canvasCreditos.SetActive(false);
        canvasApagarDados.SetActive(false);
        panelExibicao.SetActive(false);
    }

    protected void ApagarDados()
    {
        buttonExibicao.GetComponent<Button>().interactable = false;
        PlayerPrefs.DeleteAll();

    }

    protected void DarLetras()
    {
        PlayerPrefs.SetString("LetrasInventario", "AAAAAAAAAAAAAAAAAAABBBBBBBBBBBBBBBBBBBBBBCCCCCCCCCCCCCCCCCCCCDDDDDDDDDDDDDDDDDDDDDDEEEEEEEEEEEEEEEEEEEEEFFFFFFFFFFFFFFFFFFFFFFFFFFGGGGGGGGGGGGGGGGGGGGGGGGGGHHHHHHHHHHHHHHHHHHHHHHHHIIIIIIIIIIIIIIIIIIIIIIIIIIIJJJJJJJJJJJJJJJJJJJJJJJJJJJJJKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKLLLLLLLLLLLLLLLLLLLLLLLLLLLLLMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMNNNNNNNNNNNNNNNNNNNNNNNNNNNNNOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWXXXXXXXXXXXXXXXXXXXXXXXXXXXYYYYYYYYYYYYYYYYYYYYYYYYYYYYYZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
    }

    protected void FecharJogo()
    {
        Application.Quit();
    }
    
    protected void CanvasMenu()
    {
        canvasCreditos.SetActive(false);
        canvasApagarDados.SetActive(false);
        canvasMenu.SetActive(true);
    }

    protected void CanvasCreditos()
    {
        canvasMenu.SetActive(false);
        canvasApagarDados.SetActive(false);
        canvasCreditos.SetActive(true);
    }

    protected void CanvasApagarDados()
    {
        canvasMenu.SetActive(false);
        canvasCreditos.SetActive(false);
        canvasApagarDados.SetActive(true);
    }

    protected void PanelExibicao()
    {
        panelExibicao.SetActive(true);
        foreach (PalavraLoja pl in InfoPronuncia.palavraLojas) {
            if (pl.nomePremio == PlayerPrefs.GetString("PremioExibido")) {
                panelExibicao.transform.Find("FundoBranco").transform.Find("FundoCinza").transform.Find("TextPremioTitulo").GetComponent<TextMeshProUGUI>().SetText(pl.nomePremio);
                panelExibicao.transform.Find("FundoBranco").transform.Find("FundoCinza").transform.Find("ImagePremio").GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/Loja Icons/" + pl.imagemPremio);
                panelExibicao.transform.Find("FundoBranco").transform.Find("FundoCinza").transform.Find("TextPremioDescricao").GetComponent<TextMeshProUGUI>().SetText(pl.descPremio);
            }
        }
    }

    protected void FecharPanelExibicao()
    {
        panelExibicao.SetActive(false);
    }

}
