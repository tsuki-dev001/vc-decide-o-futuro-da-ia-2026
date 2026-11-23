
@import url('https://fonts.googleapis.com/css2?family=Chakra+Petch:wght@400;600;700&family=Inter&display=swap');

:root {
    --cor-fundo: #111310;
    --cor-principal: #252820;
    --cor-secundaria: #a51f1f;
    --cor-destaque: #d6a34a;
    --cor-texto: #eeeeee;
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Inter', sans-serif;
    background-color: var(--cor-fundo);
    color: var(--cor-texto);

    display: flex;
    justify-content: center;
    align-items: center;

    min-height: 100vh;
    padding: 20px;
}

.caixa-principal {
    background-color: var(--cor-principal);
    width: 90%;
    max-width: 650px;

    text-align: center;
    padding: 30px;

    border: 2px solid var(--cor-destaque);
    border-radius: 12px;

    box-shadow: 0 0 25px rgba(165, 31, 31, 0.3);
}

h1 {
    font-family: 'Chakra Petch', sans-serif;
    color: var(--cor-destaque);
    margin-bottom: 25px;
}

h2 {
    color: var(--cor-destaque);
    margin-bottom: 20px;
    font-family: 'Chakra Petch', sans-serif;
}

p {
    line-height: 1.8;
    margin-bottom: 25px;
}

button {
    background-color: var(--cor-secundaria);
    color: white;

    border: none;
    border-radius: 8px;

    padding: 15px 20px;

    font-size: 16px;
    font-weight: bold;

    cursor: pointer;
    transition: background-color 0.3s, transform 0.3s;
}

button:hover {
    background-color: var(--cor-destaque);
    color: #111310;
    transform: scale(1.03);
}

.tela-inicial {
    display: block;
}

.caixa-perguntas,
.caixa-alternativas,
.caixa-resultado {
    display: none;
}

.caixa-perguntas.mostrar,
.caixa-resultado.mostrar {
    display: block;
}

.caixa-alternativas.mostrar {
    display: flex;
}

.caixa-perguntas {
    font-size: 19px;
    line-height: 1.7;
    margin-bottom: 25px;
    color: white;
}

.caixa-alternativas {
    flex-direction: column;
    gap: 12px;
}

.caixa-alternativas button {
    width: 100%;
    text-align: center;
}

.caixa-resultado {
    margin-top: 20px;
}

.texto-resultado {
    line-height: 1.8;
}

@media (max-width: 500px) {
    .caixa-principal {
        width: 100%;
        padding: 20px;
    }

    h1 {
        font-size: 25px;
    }
}
