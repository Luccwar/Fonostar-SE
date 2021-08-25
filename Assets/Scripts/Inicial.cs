using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicial : MonoBehaviour
{
    void Start()
    {
        Palavra abacate = new Palavra();
        abacate.nome = "Abacate";
        abacate.imagemPalavra = "abacate";
        abacate.somFalado = "abacate";

        Palavra abacaxi = new Palavra();
        abacaxi.nome = "Abacaxi";
        abacaxi.imagemPalavra = "abacaxi";
        abacaxi.somFalado = "abacaxi";

        Palavra acerola = new Palavra();
        acerola.nome = "Acerola";
        acerola.imagemPalavra = "acerola";
        acerola.somFalado = "acerola";

        Palavra amora = new Palavra();
        amora.nome = "Amora";
        amora.imagemPalavra = "amora";
        amora.somFalado = "amora";

        Palavra banana = new Palavra();
        banana.nome = "Banana";
        banana.imagemPalavra = "banana";
        banana.somFalado = "banana";

        Palavra biriba = new Palavra();
        biriba.nome = "Biribá";
        biriba.imagemPalavra = "biribá";
        biriba.somFalado = "biribá";

        Palavra cacau = new Palavra();
        cacau.nome = "Cacau";
        cacau.imagemPalavra = "cacau";
        cacau.somFalado = "cacau";

        Palavra caja = new Palavra();
        caja.nome = "Cajá";
        caja.imagemPalavra = "cajá";
        caja.somFalado = "cajá";

        Palavra caqui = new Palavra();
        caqui.nome = "Caqui";
        caqui.imagemPalavra = "caqui";
        caqui.somFalado = "caqui";

        Palavra cereja = new Palavra();
        cereja.nome = "Cereja";
        cereja.imagemPalavra = "cereja";
        cereja.somFalado = "cereja";
        
        Palavra cidra = new Palavra();
        cidra.nome = "Cidra";
        cidra.imagemPalavra = "cidra";
        cidra.somFalado = "cidra";

        Palavra coco = new Palavra();
        coco.nome = "Coco";
        coco.imagemPalavra = "coco";
        coco.somFalado = "coco";

        Palavra cupuacu = new Palavra();
        cupuacu.nome = "Cupuaçu";
        cupuacu.imagemPalavra = "cupuaçu";
        cupuacu.somFalado = "cupuaçu";
        

        Letra A = new Letra();
        A.nome = "A";
        A.palavras.Add(abacate);
        A.palavras.Add(abacaxi);
        A.palavras.Add(acerola);
        A.palavras.Add(amora);

        Letra B = new Letra();
        B.nome = "B";
        B.palavras.Add(banana);
        B.palavras.Add(biriba);

        Letra C = new Letra();
        C.nome = "C";
        C.palavras.Add(cacau);
        C.palavras.Add(caja);
        C.palavras.Add(caqui);
        C.palavras.Add(cereja);
        C.palavras.Add(cidra);
        C.palavras.Add(coco);
        C.palavras.Add(cupuacu);

        
    }

    void Update()
    {
        
    }
}
