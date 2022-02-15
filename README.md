# Campo Minado   <img align="center" height="70" width="90" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" />
O jogo foi bastante difundido pelo sistema operacional Windows nos anos 90.
Robert Donner e Curt Johnson foram contratados pela Microsoft em 1989. Curt tinha escrito um programa para o sistema operacional da IBM(OS/2), cujo objetivo era você conseguir atravessar um campo minado de um canto da tela para outro ileso. Robert queria escrever um jogo para Windows para aprimorar sua programação no sistema operacional, e Curt deixou que ele utilizasse o seu código fonte como ponto de partida. Mais tarde a Microsoft decidiu lançar uma coleção de jogos para sua nova plataforma e os funcionários foram convidados a enviar jogos. O campo minado foi enviado e um dos escolhidos a pertencer ao sistema operacional.

## Objetivo do jogo
O jogo consiste em uma matriz quadrada, que ao primeiro clique revela algumas posições. A partir das posições reveladas o jogador devera descobrir todos as posições que não contêm minas terrestres sem ser "explodido". A localização das minas terrestres é descoberta através de um processo lógico, onde o número de uma determinada posição representa a quantidade de minas terrestres em volta dele.

### **Exemplo**

Aqui temos o início de um jogo, repare que a posição marcada de amarelo possui o número 1, portanto em volta deste número possui uma mina terrestre. Como possuímos apenas uma posição não aberta destacada em vermelho, indica que ela possui uma mina terrestre e que não devemos abrir está posição.

![Exemplo campo minado jogada 1](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/1.png)

Agora podemos analisar uma próxima posição (destacada de amarelo). Repare que em volta do número existem duas posições que não abrimos, mas uma possui uma bomba (descoberta na etapa anterior), portanto ficou liberado a casa destacada em verde, pois a posição atual indica que em volta existe apenas uma mina terrestre. Assim ela está livre para abrir.

![Exemplo campo minado jogada 2](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/2.png)

Outro exemplo é a casa destaca em amarelo, nesta situação onde todas as posições não abertas são iguais ao número da posição destacada, indica que todas as posições possuem uma mina terrestre.

![Exemplo campo minado jogada 3](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/3.png)

Se no passo anterior descobrimos três minas terrestres, o item destacado em amarelo possui duas minas terrestres em volta. Portanto a posição destaca em verde está livre para abrirmos.

![Exemplo campo minado jogada 3](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/4.png)


# Sobre a aplicação
Neste repositório existe uma console application construída que instancia a classe CampoMinado.

![Aplicação inicial](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/5.png)

Está classe é responsável por iniciar um novo jogo do campo minado. Nela temos disponíveis os seguintes atributos e métodos:

 - `campoMinado.Tabuleiro`: Retorna o tabuleiro atual no formato de `string`. Veja o que acontece quando imprimimos seu valor na tela (Linha 13 da imagem anterior):

![Aplicação inicial](https://github.com/ivory-it/ivoryit-testeestagio-campo-minado/blob/master/imagens/6.png) 
    
 - `Valores númericos`: Números de minas terrestres que a posição possui em volta;
 - `Traço (-)`: Posições que ainda não foram abertas, a qual o seu algoritmo deve analisar o atributo Tabuleiro e tomar a decisão de abrir ou não.

- `campoMinado.JogoStatus`: Atributo que retorna (inteiro) o status do jogo atual. A cada tentativa de abertura de uma posição o seu valor é alterado.
    - `0`: Jogo em aberto, continue procurando as posições que não possuem minas terrestres;
    - `1`: Vitoria, você encontrou todas as posições que não possuem minas terrestres;
    - `2`: Game Over, você encontrou uma mina terrestre.
- `campoMinado.Abrir(int linha, int coluna)`: Método responsável por abrir uma posição. Como o tabuleiro é uma matriz 9x9 , você deve informar linha e coluna entre 1 e 9 para abrir. Sempre que você pedir para abrir uma posição o atributo Tabuleiro é atualizado com a posição aberta e o atributo JogoStatus recebe um novo status (0, 1 ou 2). 

Como todos sabem, uma string é um vetor de caracteres, portanto o objetivo do algoritmo é realizar a leitura da string Tabuleiro utilizando a lógica de identificação das minas terrestres conforme a sessão objetivo do jogo. Após analisar e identificar que é seguro abrir uma posição, seu algoritmo deve chamar o método Abrir da classe CampoMinado. Ao abrir todas as posições que não possuem minas terrestres o atributo JogoStatus irá receber o valor 1 de vitória.

