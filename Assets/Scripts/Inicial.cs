using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        Palavra dado = new Palavra();
        dado.nome = "Dado";
        dado.imagemPalavra = "dado";
        dado.somFalado = "dado";

        Palavra dedo = new Palavra();
        dedo.nome = "Dedo";
        dedo.imagemPalavra = "dedo";
        dedo.somFalado = "dedo";

        Palavra diamante = new Palavra();
        diamante.nome = "Diamante";
        diamante.imagemPalavra = "diamante";
        diamante.somFalado = "diamante";

        Palavra elefante = new Palavra();
        elefante.nome = "Elefante";
        elefante.imagemPalavra = "elefante";
        elefante.somFalado = "elefante";

        Palavra escova = new Palavra();
        escova.nome = "Escova";
        escova.imagemPalavra = "escova";
        escova.somFalado = "escova";

        Palavra espada = new Palavra();
        espada.nome = "Espada";
        espada.imagemPalavra = "espada";
        espada.somFalado = "espada";

        Palavra faca = new Palavra();
        faca.nome = "Faca";
        faca.imagemPalavra = "faca";
        faca.somFalado = "faca";

        Palavra figo = new Palavra();
        figo.nome = "Figo";
        figo.imagemPalavra = "figo";
        figo.somFalado = "figo";

        Palavra furadeira = new Palavra();
        furadeira.nome = "Furadeira";
        furadeira.imagemPalavra = "furadeira";
        furadeira.somFalado = "furadeira";

        Palavra gelo = new Palavra();
        gelo.nome = "Gelo";
        gelo.imagemPalavra = "gelo";
        gelo.somFalado = "gelo";

        Palavra girafa = new Palavra();
        girafa.nome = "Girafa";
        girafa.imagemPalavra = "girafa";
        girafa.somFalado = "girafa";

        Palavra gota = new Palavra();
        gota.nome = "Gota";
        gota.imagemPalavra = "gota";
        gota.somFalado = "gota";

        Palavra hamburguer = new Palavra();
        hamburguer.nome = "Hambúrguer";
        hamburguer.imagemPalavra = "hamburguer";
        hamburguer.somFalado = "hamburguer";

        Palavra helice = new Palavra();
        helice.nome = "Hélice";
        helice.imagemPalavra = "helice";
        helice.somFalado = "helice";

        Palavra heroi = new Palavra();
        heroi.nome = "Herói";
        heroi.imagemPalavra = "heroi";
        heroi.somFalado = "heroi";

        Palavra igreja = new Palavra();
        igreja.nome = "Igreja";
        igreja.imagemPalavra = "igreja";
        igreja.somFalado = "igreja";

        Palavra ilha = new Palavra();
        ilha.nome = "Ilha";
        ilha.imagemPalavra = "ilha";
        ilha.somFalado = "ilha";

        Palavra ima = new Palavra();
        ima.nome = "Imã";
        ima.imagemPalavra = "ima";
        ima.somFalado = "ima";

        Palavra jacare = new Palavra();
        jacare.nome = "Jacaré";
        jacare.imagemPalavra = "jacare";
        jacare.somFalado = "jacare";

        Palavra jipe = new Palavra();
        jipe.nome = "Jipe";
        jipe.palavraContextual = "Jeep";
        jipe.imagemPalavra = "jipe";
        jipe.somFalado = "jipe";

        Palavra joaninha = new Palavra();
        joaninha.nome = "Joaninha";
        joaninha.imagemPalavra = "joaninha";
        joaninha.somFalado = "joaninha";

        Palavra kart = new Palavra();
        kart.nome = "Kart";
        kart.imagemPalavra = "kart";
        kart.somFalado = "kart";

        Palavra ketchup = new Palavra();
        ketchup.nome = "Ketchup";
        ketchup.imagemPalavra = "ketchup";
        ketchup.somFalado = "ketchup";

        Palavra kiwi = new Palavra();
        kiwi.nome = "Kiwi";
        kiwi.imagemPalavra = "kiwi";
        kiwi.somFalado = "kiwi";

        Palavra laranja = new Palavra();
        laranja.nome = "Laranja";
        laranja.imagemPalavra = "laranja";
        laranja.somFalado = "laranja";

        Palavra leao = new Palavra();
        leao.nome = "Leão";
        leao.imagemPalavra = "leao";
        leao.somFalado = "leao";

        Palavra limao = new Palavra();
        limao.nome = "Limão";
        limao.imagemPalavra = "limao";
        limao.somFalado = "limao";

        Palavra maca = new Palavra();
        maca.nome = "Maçã";
        maca.imagemPalavra = "maca";
        maca.somFalado = "maca";

        Palavra melancia = new Palavra();
        melancia.nome = "Melancia";
        melancia.imagemPalavra = "melancia";
        melancia.somFalado = "melancia";

        Palavra milho = new Palavra();
        milho.nome = "Milho";
        milho.imagemPalavra = "milho";
        milho.somFalado = "milho";

        Palavra navio = new Palavra();
        navio.nome = "Navio";
        navio.imagemPalavra = "navio";
        navio.somFalado = "navio";

        Palavra neve = new Palavra();
        neve.nome = "Neve";
        neve.imagemPalavra = "neve";
        neve.somFalado = "neve";

        Palavra ninho = new Palavra();
        ninho.nome = "Ninho";
        ninho.imagemPalavra = "ninho";
        ninho.somFalado = "ninho";

        Palavra olho = new Palavra();
        olho.nome = "Olho";
        olho.imagemPalavra = "olho";
        olho.somFalado = "olho";

        Palavra ovelha = new Palavra();
        ovelha.nome = "Ovelha";
        ovelha.imagemPalavra = "ovelha";
        ovelha.somFalado = "ovelha";

        Palavra ovo = new Palavra();
        ovo.nome = "Ovo";
        ovo.imagemPalavra = "ovo";
        ovo.somFalado = "ovo";

        Palavra pato = new Palavra();
        pato.nome = "Pato";
        pato.imagemPalavra = "pato";
        pato.somFalado = "pato";

        Palavra pena = new Palavra();
        pena.nome = "Pena";
        pena.imagemPalavra = "pena";
        pena.somFalado = "pena";

        Palavra pinguim = new Palavra();
        pinguim.nome = "Pinguim";
        pinguim.imagemPalavra = "pinguim";
        pinguim.somFalado = "pinguim";

        Palavra quatro = new Palavra();
        quatro.nome = "Quatro";
        quatro.palavraContextual = "4";
        quatro.imagemPalavra = "quatro";
        quatro.somFalado = "quatro";

        Palavra queijo = new Palavra();
        queijo.nome = "Queijo";
        queijo.imagemPalavra = "queijo";
        queijo.somFalado = "queijo";

        Palavra quiabo = new Palavra();
        quiabo.nome = "Quiabo";
        quiabo.imagemPalavra = "quiabo";
        quiabo.somFalado = "quiabo";

        Palavra rato = new Palavra();
        rato.nome = "Rato";
        rato.imagemPalavra = "rato";
        rato.somFalado = "rato";

        Palavra remedio = new Palavra();
        remedio.nome = "Remédio";
        remedio.imagemPalavra = "remedio";
        remedio.somFalado = "remedio";

        Palavra roda = new Palavra();
        roda.nome = "Roda";
        roda.imagemPalavra = "roda";
        roda.somFalado = "roda";

        Palavra sapo = new Palavra();
        sapo.nome = "Sapo";
        sapo.imagemPalavra = "sapo";
        sapo.somFalado = "sapo";

        Palavra sino = new Palavra();
        sino.nome = "Sino";
        sino.imagemPalavra = "sino";
        sino.somFalado = "sino";

        Palavra sofa = new Palavra();
        sofa.nome = "Sofá";
        sofa.imagemPalavra = "sofa";
        sofa.somFalado = "sofa";

        Palavra tapete = new Palavra();
        tapete.nome = "Tapete";
        tapete.imagemPalavra = "tapete";
        tapete.somFalado = "tapete";

        Palavra tesoura = new Palavra();
        tesoura.nome = "Tesoura";
        tesoura.imagemPalavra = "tesoura";
        tesoura.somFalado = "tesoura";

        Palavra tigre = new Palavra();
        tigre.nome = "Tigre";
        tigre.imagemPalavra = "tigre";
        tigre.somFalado = "tigre";

        Palavra urso = new Palavra();
        urso.nome = "Urso";
        urso.imagemPalavra = "urso";
        urso.somFalado = "urso";

        Palavra urubu = new Palavra();
        urubu.nome = "Urubu";
        urubu.imagemPalavra = "urubu";
        urubu.somFalado = "urubu";

        Palavra uva = new Palavra();
        uva.nome = "Uva";
        uva.imagemPalavra = "uva";
        uva.somFalado = "uva";

        Palavra vaca = new Palavra();
        vaca.nome = "Vaca";
        vaca.imagemPalavra = "vaca";
        vaca.somFalado = "vaca";

        Palavra vela = new Palavra();
        vela.nome = "Vela";
        vela.imagemPalavra = "vela";
        vela.somFalado = "vela";

        Palavra violao = new Palavra();
        violao.nome = "Violão";
        violao.imagemPalavra = "violao";
        violao.somFalado = "violao";

        Palavra xadrez = new Palavra();
        xadrez.nome = "Xadrez";
        xadrez.imagemPalavra = "xadrez";
        xadrez.somFalado = "xadrez";

        Palavra xarope = new Palavra();
        xarope.nome = "Xarope";
        xarope.imagemPalavra = "xarope";
        xarope.somFalado = "xarope";

        Palavra xicara = new Palavra();
        xicara.nome = "Xícara";
        xicara.imagemPalavra = "xicara";
        xicara.somFalado = "xicara";

        Palavra zangao = new Palavra();
        zangao.nome = "Zangão";
        zangao.imagemPalavra = "zangao";
        zangao.somFalado = "zangao";

        Palavra zebra = new Palavra();
        zebra.nome = "Zebra";
        zebra.imagemPalavra = "zebra";
        zebra.somFalado = "zebra";

        Palavra zumbi = new Palavra();
        zumbi.nome = "Zumbi";
        zumbi.imagemPalavra = "zumbi";
        zumbi.somFalado = "zumbi";



        

        
        

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

        Letra D = new Letra();
        D.nome = "D";
        D.palavras.Add(dado);
        D.palavras.Add(dedo);
        D.palavras.Add(diamante);

        Letra E = new Letra();
        E.nome = "E";
        E.palavras.Add(elefante);
        E.palavras.Add(escova);
        E.palavras.Add(espada);

        Letra F = new Letra();
        F.nome = "F";
        F.palavras.Add(faca);
        F.palavras.Add(figo);
        F.palavras.Add(furadeira);

        Letra G = new Letra();
        G.nome = "G";
        G.palavras.Add(gelo);
        G.palavras.Add(girafa);
        G.palavras.Add(gota);

        Letra H = new Letra();
        H.nome = "H";
        H.palavras.Add(hamburguer);
        H.palavras.Add(helice);
        H.palavras.Add(heroi);

        Letra I = new Letra();
        I.nome = "I";
        I.palavras.Add(igreja);
        I.palavras.Add(ilha);
        I.palavras.Add(ima);

        Letra J = new Letra();
        J.nome = "J";
        J.palavras.Add(jacare);
        J.palavras.Add(jipe);
        J.palavras.Add(joaninha);

        Letra K = new Letra();
        K.nome = "K";
        K.palavras.Add(kart);
        K.palavras.Add(ketchup);
        K.palavras.Add(kiwi);

        Letra L = new Letra();
        L.nome = "L";
        L.palavras.Add(laranja);
        L.palavras.Add(leao);
        L.palavras.Add(limao);

        Letra M = new Letra();
        M.nome = "M";
        M.palavras.Add(maca);
        M.palavras.Add(melancia);
        M.palavras.Add(milho);

        Letra N = new Letra();
        N.nome = "N";
        N.palavras.Add(navio);
        N.palavras.Add(neve);
        N.palavras.Add(ninho);

        Letra O = new Letra();
        O.nome = "O";
        O.palavras.Add(olho);
        O.palavras.Add(ovelha);
        O.palavras.Add(ovo);

        Letra P = new Letra();
        P.nome = "P";
        P.palavras.Add(pato);
        P.palavras.Add(pena);
        P.palavras.Add(pinguim);

        Letra Q = new Letra();
        Q.nome = "Q";
        Q.palavras.Add(quatro);
        Q.palavras.Add(queijo);
        Q.palavras.Add(quiabo);

        Letra R = new Letra();
        R.nome = "R";
        R.palavras.Add(rato);
        R.palavras.Add(remedio);
        R.palavras.Add(roda);

        Letra S = new Letra();
        S.nome = "S";
        S.palavras.Add(sapo);
        S.palavras.Add(sino);
        S.palavras.Add(sofa);

        Letra T = new Letra();
        T.nome = "T";
        T.palavras.Add(tapete);
        T.palavras.Add(tesoura);
        T.palavras.Add(tigre);

        Letra U = new Letra();
        U.nome = "U";
        U.palavras.Add(urso);
        U.palavras.Add(urubu);
        U.palavras.Add(uva);

        Letra V = new Letra();
        V.nome = "V";
        V.palavras.Add(vaca);
        V.palavras.Add(vela);
        V.palavras.Add(violao);

        Letra W = new Letra();
        W.nome = "W";

        Letra X = new Letra();
        X.nome = "X";
        X.palavras.Add(xadrez);
        X.palavras.Add(xarope);
        X.palavras.Add(xicara);

        Letra Y = new Letra();
        Y.nome = "Y";

        Letra Z = new Letra();
        Z.nome = "Z";
        Z.palavras.Add(zangao);
        Z.palavras.Add(zebra);
        Z.palavras.Add(zumbi);


        Palavra palavraNave = new Palavra();
        palavraNave.nome = "Nave";
        palavraNave.imagemPalavra = "";
        palavraNave.somFalado = "nave";

        Palavra palavraCapacete = new Palavra();
        palavraCapacete.nome = "Capacete";
        palavraCapacete.imagemPalavra = "";
        palavraCapacete.somFalado = "capacete";

        Palavra palavraResistenciaUm = new Palavra();
        palavraResistenciaUm.nome = "Resistencia";
        palavraResistenciaUm.imagemPalavra = "";
        palavraResistenciaUm.somFalado = "resistencia";

        Palavra palavraResistenciaDois = new Palavra();
        palavraResistenciaDois.nome = "Duravel";
        palavraResistenciaDois.imagemPalavra = "";
        palavraResistenciaDois.somFalado = "duravel";

        Palavra palavraResistenciaTres = new Palavra();
        palavraResistenciaTres.nome = "Fortificado";
        palavraResistenciaTres.imagemPalavra = "";
        palavraResistenciaTres.somFalado = "fortificado";

        Palavra palavraAtaqueUm = new Palavra();
        palavraAtaqueUm.nome = "Ataque";
        palavraAtaqueUm.imagemPalavra = "";
        palavraAtaqueUm.somFalado = "ataque";

        Palavra palavraVidaExtra = new Palavra();
        palavraVidaExtra.nome = "Vida";
        palavraVidaExtra.imagemPalavra = "";
        palavraVidaExtra.somFalado = "vida";

        Palavra palavraExemplo = new Palavra();
        palavraExemplo.nome = "Exemplo";
        palavraExemplo.imagemPalavra = "";
        palavraExemplo.somFalado = "exemplo";

        Palavra palavraCobaia = new Palavra();
        palavraCobaia.nome = "Cobaia";
        palavraCobaia.imagemPalavra = "";
        palavraCobaia.somFalado = "cobaia";

        Palavra palavraTestamento = new Palavra();
        palavraTestamento.nome = "Testamento";
        palavraTestamento.imagemPalavra = "";
        palavraTestamento.somFalado = "testamento";

        Palavra palavraParagrafo = new Palavra();
        palavraParagrafo.nome = "Paragrafo";
        palavraParagrafo.imagemPalavra = "";
        palavraParagrafo.somFalado = "paragrafo";

        Palavra palavraSubconsciente = new Palavra();
        palavraSubconsciente.nome = "Subconsciente";
        palavraSubconsciente.imagemPalavra = "";
        palavraSubconsciente.somFalado = "subconsciente";

        Palavra palavraCoragem = new Palavra();
        palavraCoragem.nome = "Coragem";
        palavraCoragem.imagemPalavra = "";
        palavraCoragem.somFalado = "coragem";

        Palavra palavraHeroismo = new Palavra();
        palavraHeroismo.nome = "Heroismo";
        palavraHeroismo.imagemPalavra = "";
        palavraHeroismo.somFalado = "heroismo";

        Palavra palavraPoder = new Palavra();
        palavraPoder.nome = "Poder";
        palavraPoder.imagemPalavra = "";
        palavraPoder.somFalado = "poder";

        Palavra palavraMadeira = new Palavra();
        palavraMadeira.nome = "Madeira";
        palavraMadeira.imagemPalavra = "";
        palavraMadeira.somFalado = "madeira";

        Palavra palavraGelido = new Palavra();
        palavraGelido.nome = "Gelido";
        palavraGelido.imagemPalavra = "";
        palavraGelido.somFalado = "gelido";

        Palavra palavraVenenoso = new Palavra();
        palavraVenenoso.nome = "Venenoso";
        palavraVenenoso.imagemPalavra = "";
        palavraVenenoso.somFalado = "venenoso";

        Palavra palavraEscorpiao = new Palavra();
        palavraEscorpiao.nome = "Escorpiao";
        palavraEscorpiao.imagemPalavra = "";
        palavraEscorpiao.somFalado = "escorpiao";

        Palavra palavraSantificado = new Palavra();
        palavraSantificado.nome = "Santificado";
        palavraSantificado.imagemPalavra = "";
        palavraSantificado.somFalado = "santificado";

        Palavra palavraPrecioso = new Palavra();
        palavraPrecioso.nome = "Precioso";
        palavraPrecioso.imagemPalavra = "";
        palavraPrecioso.somFalado = "precioso";

        Palavra palavraChapeu = new Palavra();
        palavraChapeu.nome = "Chapeu";
        palavraChapeu.imagemPalavra = "";
        palavraChapeu.somFalado = "chapeu";





        PalavraLoja nave = new PalavraLoja();
        nave.palavra = palavraNave;
        nave.nomePremio = "Nave";
        nave.imagemPremio = "abacate";
        nave.descPremio = "Derrote oponentes com uma nave novinha em folha.";
        nave.palavraAnterior = "";


        PalavraLoja capa = new PalavraLoja();
        capa.palavra = palavraCapacete;
        capa.nomePremio = "Capacete";
        capa.imagemPremio = "capacete";
        capa.descPremio = "Consiga uma proteção avançada com um capacete forjado por artesãos cearenses.";
        capa.palavraAnterior = "";

        PalavraLoja resistenciaUm = new PalavraLoja();
        resistenciaUm.palavra = palavraResistenciaUm;
        resistenciaUm.nomePremio = "Resistência +1";
        resistenciaUm.imagemPremio = "resistencia1";
        resistenciaUm.descPremio = "Torne sua nave mais resistente com essa melhoria para o seu escudo.";
        resistenciaUm.palavraAnterior = "";

        PalavraLoja resistenciaDois = new PalavraLoja();
        resistenciaDois.palavra = palavraResistenciaDois;
        resistenciaDois.nomePremio = "Resistência +2";
        resistenciaDois.imagemPremio = "resistencia2";
        resistenciaDois.descPremio = "Torne sua nave ainda mais resistente com essa melhoria para o seu escudo.";
        resistenciaDois.palavraAnterior = "Resistencia";

        PalavraLoja resistenciaTres = new PalavraLoja();
        resistenciaTres.palavra = palavraResistenciaTres;
        resistenciaTres.nomePremio = "Resistência +3";
        resistenciaTres.imagemPremio = "resistencia3";
        resistenciaTres.descPremio = "Torne sua nave quase impenetrável com essa melhoria para o seu escudo.";
        resistenciaTres.palavraAnterior = "Duravel";

        PalavraLoja ataqueUm = new PalavraLoja();
        ataqueUm.palavra = palavraAtaqueUm;
        ataqueUm.nomePremio = "Ataque +1";
        ataqueUm.imagemPremio = "ataque1";
        ataqueUm.descPremio = "Aumente seu poder de fogo com essa melhoria fenômenal.";
        ataqueUm.palavraAnterior = "";

        PalavraLoja vidaExtra = new PalavraLoja();
        vidaExtra.palavra = palavraVidaExtra;
        vidaExtra.nomePremio = "Vida Extra";
        vidaExtra.imagemPremio = "vidaExtra";
        vidaExtra.descPremio = "Ganhe uma vida extra para retornar a batalha de forma triunfal.";
        vidaExtra.palavraAnterior = "";

        PalavraLoja testeUm = new PalavraLoja();
        testeUm.palavra = palavraExemplo;
        testeUm.nomePremio = "Exemplo";
        testeUm.imagemPremio = "";
        testeUm.descPremio = "Isto é só um exemplo para realização de testes, você provavelmente não deveria estar vendo isso.";
        testeUm.palavraAnterior = "";

        PalavraLoja testeDois = new PalavraLoja();
        testeDois.palavra = palavraCobaia;
        testeDois.nomePremio = "Cobaia";
        testeDois.imagemPremio = "";
        testeDois.descPremio = "Isto é só um exemplo para realização de testes, você provavelmente não deveria estar vendo isso.";
        testeDois.palavraAnterior = "";

        PalavraLoja testeTres = new PalavraLoja();
        testeTres.palavra = palavraTestamento;
        testeTres.nomePremio = "Testamento";
        testeTres.imagemPremio = "";
        testeTres.descPremio = "Isto é só um exemplo para realização de testes, você provavelmente não deveria estar vendo isso.";
        testeTres.palavraAnterior = "";

        PalavraLoja testeQuatro = new PalavraLoja();
        testeQuatro.palavra = palavraParagrafo;
        testeQuatro.nomePremio = "Parágrafo";
        testeQuatro.imagemPremio = "";
        testeQuatro.descPremio = "Isto é só um exemplo para realização de testes, você provavelmente não deveria estar vendo isso.";
        testeQuatro.palavraAnterior = "";

        PalavraLoja testeCinco = new PalavraLoja();
        testeCinco.palavra = palavraSubconsciente;
        testeCinco.nomePremio = "Subconciente";
        testeCinco.imagemPremio = "";
        testeCinco.descPremio = "Isto é só um exemplo para realização de testes, você provavelmente não deveria estar vendo isso.";
        testeCinco.palavraAnterior = "";

        
        // PalavraLojas que serão adicionadas abaixo abaixo
        PalavraLoja coragem = new PalavraLoja();
        coragem.palavra = palavraCoragem;
        coragem.nomePremio = "Emblema da Coragem";
        coragem.imagemPremio = "Coragem";
        coragem.descPremio = "Demonstre sua coragem com este emblema.";
        coragem.palavraAnterior = "";
        coragem.exibivel = true;

        PalavraLoja heroismo = new PalavraLoja();
        heroismo.palavra = palavraHeroismo;
        heroismo.nomePremio = "Emblema do Heroísmo";
        heroismo.imagemPremio = "Heroismo";
        heroismo.descPremio = "Mostre seu heroísmo ao ostentar este emblema.";
        heroismo.palavraAnterior = "";
        heroismo.exibivel = true;


        PalavraLoja poder = new PalavraLoja();
        poder.palavra = palavraPoder;
        poder.nomePremio = "Emblema do Poder";
        poder.imagemPremio = "Poder";
        poder.descPremio = "Apresente este emblema para exibir seu poder.";
        poder.palavraAnterior = "";
        poder.exibivel = true;

        PalavraLoja madeira = new PalavraLoja();
        madeira.palavra = palavraMadeira;
        madeira.nomePremio = "Escudo de Madeira";
        madeira.imagemPremio = "Madeira";
        madeira.descPremio = "Este escudo evidencia sua proficiência com madeira.";
        madeira.palavraAnterior = "";
        madeira.exibivel = true;

        PalavraLoja gelido = new PalavraLoja();
        gelido.palavra = palavraGelido;
        gelido.nomePremio = "Escudo Gélido";
        gelido.imagemPremio = "Gelido";
        gelido.descPremio = "Este escudo anuncia que você possui capacidade para sobreviver em ambientes extremos.";
        gelido.palavraAnterior = "";
        gelido.exibivel = true;

        PalavraLoja venenoso = new PalavraLoja();
        venenoso.palavra = palavraVenenoso;
        venenoso.nomePremio = "Escudo Venenoso";
        venenoso.imagemPremio = "Venenoso";
        venenoso.descPremio = "Este escudo manifesta sua dominância sobre os elementos mais perigosos existentes.";
        venenoso.palavraAnterior = "";
        venenoso.exibivel = true;

        PalavraLoja escorpiao = new PalavraLoja();
        escorpiao.palavra = palavraEscorpiao;
        escorpiao.nomePremio = "Amuleto de Escorpião";
        escorpiao.imagemPremio = "Escorpiao";
        escorpiao.descPremio = "Um amuleto na forma de um escorpião que protege o usuário da temível criatura que dá seu nome.";
        escorpiao.palavraAnterior = "";
        escorpiao.exibivel = true;

        PalavraLoja santificado = new PalavraLoja();
        santificado.palavra = palavraSantificado;
        santificado.nomePremio = "Amuleto Santificado";
        santificado.imagemPremio = "Santificado";
        santificado.descPremio = "Um amuleto no formato de uma cruz. Rumores dizem que seu usuário recebe proteção divina.";
        santificado.palavraAnterior = "";
        santificado.exibivel = true;

        PalavraLoja precioso = new PalavraLoja();
        precioso.palavra = palavraPrecioso;
        precioso.nomePremio = "Amuleto Precioso";
        precioso.imagemPremio = "Precioso";
        precioso.descPremio = "Um amuleto que possui pedras preciosas embuídas em si. Acredita-se que não possui propriedades mágicas, mas deve valer bastante nas mãos certas.";
        precioso.palavraAnterior = "";
        precioso.exibivel = false;

        PalavraLoja chapeu = new PalavraLoja();
        chapeu.palavra = palavraChapeu;
        chapeu.nomePremio = "Chapéu Mágico";
        chapeu.imagemPremio = "Chapeu";
        chapeu.descPremio = "Um chapéu de aparência curioso. Acredita-se que possua propriedades mágicas.";
        chapeu.palavraAnterior = "";
        chapeu.exibivel = false;
        

        //LetraInventario letraInventario1 = new LetraInventario();


        Usuario usuario1 = new Usuario();
        usuario1.nome = "Jeremias";
        usuario1.email = "jeremias@fapergs.com";
        usuario1.inventario = PlayerPrefs.GetString("LetrasInventario");
        usuario1.palavrasObtidas = PlayerPrefs.GetString("PalavrasObtidas");
        //usuario1.inventario = letraInventario1;


        InfoPronuncia.letras = new List<Letra>();
        InfoPronuncia.letras.Add(A);
        InfoPronuncia.letras.Add(B);
        InfoPronuncia.letras.Add(C);
        InfoPronuncia.letras.Add(D);
        InfoPronuncia.letras.Add(E);
        InfoPronuncia.letras.Add(F);
        InfoPronuncia.letras.Add(G);
        InfoPronuncia.letras.Add(H);
        InfoPronuncia.letras.Add(I);
        InfoPronuncia.letras.Add(J);
        InfoPronuncia.letras.Add(K);
        InfoPronuncia.letras.Add(L);
        InfoPronuncia.letras.Add(M);
        InfoPronuncia.letras.Add(N);
        InfoPronuncia.letras.Add(O);
        InfoPronuncia.letras.Add(P);
        InfoPronuncia.letras.Add(Q);
        InfoPronuncia.letras.Add(R);
        InfoPronuncia.letras.Add(S);
        InfoPronuncia.letras.Add(T);
        InfoPronuncia.letras.Add(U);
        InfoPronuncia.letras.Add(V);
        //InfoPronuncia.letras.Add(W);
        InfoPronuncia.letras.Add(X);
        //InfoPronuncia.letras.Add(Y);
        InfoPronuncia.letras.Add(Z);

        InfoPronuncia.palavraLojas = new List<PalavraLoja>();
        // InfoPronuncia.palavraLojas.Add(nave);
        // InfoPronuncia.palavraLojas.Add(capa);
        // InfoPronuncia.palavraLojas.Add(resistenciaUm);
        // InfoPronuncia.palavraLojas.Add(resistenciaDois);
        // InfoPronuncia.palavraLojas.Add(resistenciaTres);
        // InfoPronuncia.palavraLojas.Add(ataqueUm);
        // InfoPronuncia.palavraLojas.Add(vidaExtra);
        // InfoPronuncia.palavraLojas.Add(testeUm);
        // InfoPronuncia.palavraLojas.Add(testeDois);
        // InfoPronuncia.palavraLojas.Add(testeTres);
        // InfoPronuncia.palavraLojas.Add(testeQuatro);
        // InfoPronuncia.palavraLojas.Add(testeCinco);
        InfoPronuncia.palavraLojas.Add(coragem);
        InfoPronuncia.palavraLojas.Add(heroismo);
        InfoPronuncia.palavraLojas.Add(poder);
        InfoPronuncia.palavraLojas.Add(madeira);
        InfoPronuncia.palavraLojas.Add(gelido);
        InfoPronuncia.palavraLojas.Add(venenoso);
        InfoPronuncia.palavraLojas.Add(escorpiao);
        InfoPronuncia.palavraLojas.Add(santificado);
        InfoPronuncia.palavraLojas.Add(precioso);
        InfoPronuncia.palavraLojas.Add(chapeu);


        InfoPronuncia.usuarios = new List<Usuario>();
        InfoPronuncia.usuarios.Add(usuario1);
        InfoPronuncia.usuarioAtivo = usuario1;

        //Debug.Log(usuario1.inventario);
        
        trocarCena();
    }

    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            string letraInventario = PlayerPrefs.GetString("PalavraDesejada").Substring(0, 1);
            PlayerPrefs.SetString("LetrasInventario", PlayerPrefs.GetString("LetrasInventario") + letraInventario);
            Debug.Log(PlayerPrefs.GetString("LetrasInventario"));
        }
        if(Input.GetKeyDown("space"))
        {
            var str = PlayerPrefs.GetString("LetrasInventario");
            var l = PlayerPrefs.GetString("PalavraDesejada").Substring(0, 1);
            var i = str.IndexOf(l);
            string j = "";
            // i will be the index of the first occurrence of 'p' in str, or -1 if not found.

            if (i == -1)
            {
                // not found
            }
            else
            {
                do
                {
                    j = j + l;
                    i = str.IndexOf(l, i + 1);
                } while (i != -1);
            }
            Debug.Log(j);
        }
    }

    public static void trocarCena()
    {
        SceneManager.LoadScene("CenaInicial");
        InfoPronuncia.usuarios[0].inventario = PlayerPrefs.GetString("LetrasInventario");
        InfoPronuncia.usuarios[0].palavrasObtidas = PlayerPrefs.GetString("PalavrasObtidas");
        InfoPronuncia.usuarioAtivo = InfoPronuncia.usuarios[0];
        Debug.Log(InfoPronuncia.usuarioAtivo.inventario);
    }

    public static void trocarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
        InfoPronuncia.usuarios[0].inventario = PlayerPrefs.GetString("LetrasInventario");
        InfoPronuncia.usuarios[0].palavrasObtidas = PlayerPrefs.GetString("PalavrasObtidas");
        //Debug.Log(InfoPronuncia.usuarioAtivo.inventario);
    }

    public void fecharJogo()
    {
        Application.Quit();
    }
}
