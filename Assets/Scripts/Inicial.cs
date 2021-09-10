using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicial : MonoBehaviour
{
    void Awake()
    {
        Palavra abacaxi = new Palavra();
        abacaxi.nome = "Abacaxi";
        abacaxi.imagemPalavra = "abacaxi";
        abacaxi.somFalado = "abacaxi";

        Palavra alface = new Palavra();
        alface.nome = "Alface";
        alface.imagemPalavra = "alface";
        alface.somFalado = "alface";

        Palavra anel = new Palavra();
        anel.nome = "Anel";
        anel.imagemPalavra = "anel";
        anel.somFalado = "anel";

        Palavra bala = new Palavra();
        bala.nome = "Bala";
        bala.imagemPalavra = "bala";
        bala.somFalado = "bala";

        Palavra bambu = new Palavra();
        bambu.nome = "Bambu";
        bambu.imagemPalavra = "bambu";
        bambu.somFalado = "bambu";

        Palavra buzina = new Palavra();
        buzina.nome = "Buzina";
        buzina.imagemPalavra = "buzina";
        buzina.somFalado = "buzina";

        Palavra capacete = new Palavra();
        capacete.nome = "Capacete";
        capacete.imagemPalavra = "capacete";
        capacete.somFalado = "capacete";

        Palavra cenoura = new Palavra();
        cenoura.nome = "Cenoura";
        cenoura.imagemPalavra = "cenoura";
        cenoura.somFalado = "cenoura";

        Palavra cueca = new Palavra();
        cueca.nome = "Cueca";
        cueca.imagemPalavra = "cueca";
        cueca.somFalado = "cueca";
        

        Letra A = new Letra();
        A.nome = "A";
        A.palavras.Add(abacaxi);
        A.palavras.Add(alface);
        A.palavras.Add(anel);

        Letra B = new Letra();
        B.nome = "B";
        B.palavras.Add(bala);
        B.palavras.Add(bambu);
        B.palavras.Add(buzina);

        Letra C = new Letra();
        C.nome = "C";
        C.palavras.Add(capacete);
        C.palavras.Add(cenoura);
        C.palavras.Add(cueca);

        InfoPronuncia.letras = new List<Letra>();
        InfoPronuncia.letras.Add(A);
        InfoPronuncia.letras.Add(B);
        InfoPronuncia.letras.Add(C);

        PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        
    }
}
