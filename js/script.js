
import { perguntas } from './perguntas.js';
import { aleatorio, nome } from './aleatorio.js';

// Selecionando os elementos do HTML
const caixaPerguntas = document.querySelector(".caixa-perguntas");
const caixaAlternativas = document.querySelector(".caixa-alternativas");
const caixaResultado = document.querySelector(".caixa-resultado");
const textoResultado = document.querySelector(".texto-resultado");

const botaoIniciar = document.querySelector(".iniciar-btn");
const botaoJogarNovamente = document.querySelector(".novamente-btn");

const telaInicial = document.querySelector(".tela-inicial");

// Variáveis do jogo
let atual = 0;
let perguntaAtual;
let historiaFinal = "";

// Mostra as perguntas
function mostraPergunta() {

    if (atual >= perguntas.length) {
        mostraResultado();
        return;
    }

    perguntaAtual = perguntas[atual];

    caixaPerguntas.textContent = perguntaAtual.enunciado;

    caixaPerguntas.classList.add("mostrar");
    caixaAlternativas.classList.add("mostrar");

    caixaResultado.classList.remove("mostrar");

    mostraAlternativas();
}

// Cria os botões das alternativas
function mostraAlternativas() {

    caixaAlternativas.textContent = "";

    for (const alternativa of perguntaAtual.alternativas) {

        const botaoAlternativa = document.createElement("button");

        botaoAlternativa.textContent = alternativa.texto;

        botaoAlternativa.addEventListener("click", () => {
            respostaSelecionada(alternativa);
        });

        caixaAlternativas.appendChild(botaoAlternativa);
    }
}

// Registra a resposta escolhida
function respostaSelecionada(opcaoSelecionada) {

    const afirmacao = aleatorio(opcaoSelecionada.afirmacao);

    historiaFinal += afirmacao + " ";

    if (opcaoSelecionada.proxima !== undefined) {
        atual = opcaoSelecionada.proxima;
        mostraPergunta();
    } else {
        atual++;
        mostraResultado();
    }
}

// Mostra o resultado final
function mostraResultado() {

    caixaPerguntas.classList.remove("mostrar");
    caixaAlternativas.classList.remove("mostrar");

    caixaAlternativas.textContent = "";

    textoResultado.textContent =
        `${nome}, sua missão chegou ao fim! ` + historiaFinal;

    caixaResultado.classList.add("mostrar");
}

// Inicia o jogo
function iniciaJogo() {

    atual = 0;
    historiaFinal = "";

    telaInicial.style.display = "none";

    caixaResultado.classList.remove("mostrar");

    mostraPergunta();
}

// Reinicia o jogo
function jogaNovamente() {

    atual = 0;
    historiaFinal = "";

    caixaResultado.classList.remove("mostrar");

    mostraPergunta();
}

// Eventos dos botões
botaoIniciar.addEventListener("click", iniciaJogo);

botaoJogarNovamente.addEventListener("click", jogaNovamente);
