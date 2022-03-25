using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private GameObject buttonPronuncia;
    private GameObject buttonInventario;
    private GameObject buttonLoja;
    private GameObject buttonApagarDados;
    private GameObject buttonDarLetras;
    private GameObject buttonSair;
    // Start is called before the first frame update
    void Start()
    {
        buttonPronuncia = GameObject.Find("ButtonPronuncia");
        buttonPronuncia.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("ListaLetra");});
        // buttonInventario = GameObject.Find("ButtonInventario");
        // buttonInventario.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("InventarioLetra");});
        // buttonLoja = GameObject.Find("ButtonLoja");
        // buttonLoja.GetComponent<Button>().onClick.AddListener(delegate{Inicial.trocarCena("LojaPalavra");});
        buttonApagarDados = GameObject.Find("ButtonApagarDados");
        buttonApagarDados.GetComponent<Button>().onClick.AddListener(delegate{ApagarDados();});
        buttonDarLetras = GameObject.Find("ButtonDarLetras");
        buttonDarLetras.GetComponent<Button>().onClick.AddListener(delegate{DarLetras();});
        buttonSair = GameObject.Find("ButtonSair");
        buttonSair.GetComponent<Button>().onClick.AddListener(delegate{FecharJogo();});
    }

    protected void ApagarDados()
    {
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

}
