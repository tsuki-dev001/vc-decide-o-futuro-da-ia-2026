
@import url('https://fonts.googleapis.com/css2?family=Chakra+Petch:wght@400;500;600;700&family=Inter:wght@400;500;600;700&display=swap');

/* CORES DO JOGO */
:root {
    --cor-fundo: #050914;
    --cor-principal: #0c1629;
    --cor-secundaria: #102747;
    --cor-destaque: #168cff;
    --cor-neon: #42b6ff;
    --cor-texto: #eaf4ff;
    --cor-borda: #193c63;
}

/* CONFIGURAÇÕES GERAIS */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Inter', sans-serif;
    color: var(--cor-texto);

    min-height: 100vh;

    display: flex;
    justify-content: center;
    align-items: center;

    padding: 25px;

    background:
        radial-gradient(ellipse at top, #102b50 0%, transparent 55%),
        linear-gradient(135deg, #030711, #071426, #02050c);

    background-attachment: fixed;
}

/* CAIXA PRINCIPAL */
.caixa-principal {
    position: relative;

    background: linear-gradient(
        145deg,
        rgba(15, 34, 60, 0.97),
        rgba(5, 13, 27, 0.98)
    );

    width: 90%;
    max-width: 700px;

    text-align: center;

    padding: 45px 35px;

    border: 1px solid #245487;
    border-radius: 20px;

    box-shadow:
        0 0 20px rgba(0, 119, 255, 0.12),
        0 0 60px rgba(0, 80, 180, 0.12),
        0 20px 50px rgba(0, 0, 0, 0.6);

    animation: aparecer 0.8s ease;
}

/* LINHA AZUL NO TOPO */
.caixa-principal::before {
    content: "";

    position: absolute;
    top: 0;
    left: 15%;

    width: 70%;
    height: 2px;

    background: linear-gradient(
        90deg,
        transparent,
        #168cff,
        #70d5ff,
        #168cff,
        transparent
    );

    box-shadow: 0 0 15px #168cff;
}

/* TÍTULOS */
h1 {
    font-family: 'Chakra Petch', sans-serif;

    font-size: 35px;
    font-weight: 700;

    color: #65baff;

    text-transform: uppercase;
    letter-spacing: 2px;

    margin-bottom: 30px;

    text-shadow: 0 0 15px rgba(22, 140, 255, 0.5);
}

h2 {
    font-family: 'Chakra Petch', sans-serif;

    font-size: 24px;

    color: #54b5ff;

    margin-bottom: 20px;
}

/* TEXTOS */
p {
    color: #c8d9ed;

    font-size: 15px;
    line-height: 1.9;

    margin-bottom: 25px;
}

/* BOTÕES */
button {
    background: linear-gradient(
        135deg,
        #0755a3,
        #087fe5
    );

    color: white;

    border: 1px solid #319bff;
    border-radius: 10px;

    padding: 15px 22px;

    font-family: 'Inter', sans-serif;
    font-size: 15px;
    font-weight: 600;

    cursor: pointer;

    transition: all 0.3s ease;

    box-shadow: 0 5px 18px rgba(0, 100, 220, 0.2);
}

/* EFEITO AO PASSAR O MOUSE */
button:hover {
    background: linear-gradient(
        135deg,
        #168cff,
        #45baff
    );

    color: #020914;

    transform: translateY(-3px);

    box-shadow:
        0 0 15px rgba(22, 140, 255, 0.7),
        0 0 30px rgba(22, 140, 255, 0.3);
}

button:active {
    transform: scale(0.97);
}

/* TELA INICIAL */
.tela-inicial {
    display: block;
}

/* PERGUNTAS */
.caixa-perguntas {
    font-family: 'Chakra Petch', sans-serif;

    color: #eaf4ff;

    font-size: 20px;
    font-weight: 600;

    line-height: 1.7;

    margin-bottom: 30px;

    padding: 20px;

    background: rgba(14, 38, 69, 0.65);

    border-left: 3px solid #168cff;
    border-radius: 8px;
}

/* ALTERNATIVAS */
.caixa-alternativas {
    flex-direction: column;
    gap: 15px;
}

.caixa-alternativas button {
    width: 100%;

    text-align: left;

    padding: 18px 20px;

    background: linear-gradient(
        120deg,
        #101f36,
        #142d4d
    );

    border: 1px solid #245487;

    color: #dceeff;

    border-radius: 10px;
}

.caixa-alternativas button:hover {
    background: linear-gradient(
        120deg,
        #0755a3,
        #087fe5
    );

    border-color: #65baff;

    color: white;

    transform: translateX(5px);
}

/* RESULTADO FINAL */
.caixa-resultado {
    margin-top: 25px;

    padding: 25px;

    background: rgba(10, 30, 55, 0.8);

    border: 1px solid #168cff;
    border-radius: 12px;

    box-shadow: 0 0 20px rgba(22, 140, 255, 0.12);
}

/* ESCONDER ELEMENTOS */
.caixa-perguntas,
.caixa-alternativas,
.caixa-resultado {
    display: none;
}

/* MOSTRAR ELEMENTOS */
.caixa-perguntas.mostrar,
.caixa-resultado.mostrar {
    display: block;
}

.caixa-alternativas.mostrar {
    display: flex;
}

/* ANIMAÇÃO */
@keyframes aparecer {
    from {
        opacity: 0;
        transform: translateY(20px);
    }

    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* RESPONSIVIDADE */
@media (max-width: 600px) {

    body {
        padding: 15px;
    }

    .caixa-principal {
        width: 100%;
        padding: 30px 20px;
    }

    h1 {
        font-size: 26px;
    }

    h2 {
        font-size: 21px;
    }

    .caixa-perguntas {
        font-size: 17px;
    }

    button {
        font-size: 14px;
    }
}
