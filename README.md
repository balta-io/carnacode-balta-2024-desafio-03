![banner-carnacode](https://github.com/balta-io/carnacode-balta-2024-desafio-01/assets/965305/b8cc442c-d64f-4dd1-9414-7fc896b47183)

# CarnaCode 2024 - Desafio 3
O CarnaCode é um evento online e gratuito que acontece nos dias 10, 11, 12 e 13 de Fevereiro, onde você terá a oportunidade de codificar uma aplicação Web (Blazor + PWA) completa, do começo ao fim.


👉 https://go.balta.io/carnacode-2024

## Sobre o Desafio

Neste segundo desafio, desenvolvemos uma aplicação completa para calcular o IMC (Índice de Massa Muscular). Aprendemos conceitos como Razor e Blazor, bem como rotas, componentes e outros itens do ASP.NET.

## Assuntos a pesquisar

- Localstorage
- Componentes
- JsInterop
- Data Bindings
- Validação de Formulários
- Child Content

## Desafios

Fácil: 
	* Adicionar suporte a PWA
	* Ajustar manisfeto
	* Publish local

Médio: 
	* Salvar as informações no localstorage.

Avançado: 
	*Componentizar o cálculo do IMC.

### Tecnologias Utilizadas
* ASP.NET
* Razor
* Blazor
* PWA
* Git
* GitHub
* CI/CD
* GitHub Actions
* GitHub Pages

### Ferramentas Utilizadas
* Visual Studio

# Recompensa
<img src="https://baltaio.blob.core.windows.net/temp/carnacode-badge-desafio-03.png" alt="CarnaCode 2024 - Terceiro Desafio Completo" width="256" />

 ###  Grupo 01
* [Eliane Henriqueta](https://github.com/Elianehenri)
* [Pablo Alessandre](https://github.com/pabloalessandre)
* [Gabriele Felice](https://github.com/gabi-felice-dev)
* [Julio](https://github.com/mitsugui)


# Passo a passo
1. Copiar arquivos do desafio 2 na pasta clonada (sem .git)
2. Gerar o ícone da aplicação:
	1. Instalar a extensão PWABuilder.
	2. Abrir Icon Generator
	3. Escolher o ícone que está no Assests
	4. Ajustar cor de fundo #2E1462 rgb(46, 20, 98)
	5. Padding de 0
	6. Criar pasta wwwroot/imgs
	7. Colocar ícones na pasta
3. Editar o manifesto
	1. Ajustar os ícones:
```JSON
[
    {
        "src": "imgs/manifest-icon-512.maskable.png",
        "type": "image/png",
        "sizes": "512x512"
    },
    {
        "src": "imgs/manifest-icon-192.maskable.png",
        "type": "image/png",
        "sizes": "192x192"
    },
    {
        "src": "imgs/apple-icon-180.png",
        "type": "image/png",
        "sizes": "180x180"
    }
]
````
4. Fazer publish para pasta:
    1. No Visual Studio basta clicar com botão direito no projeto e escolher Publish...
    2. Escolher a opção de publicação para uma pasta.
    3. Publicar a aplicação.
5. Executar um servidor web
    1. ```npm install -g http-server```
    2. Navegar até a pasta wwwroot que está dentro da pasta publicada (procurar o último nível)
    3. Executar ```http-server -c1```
    4. Abrir no browser.