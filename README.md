# Excecoes-E-Colecoes-Em-CSharp
Este repositório é um resumo da aula sobre Exceções e Coleções do Bootcamp Decola Tech 2024 da DIO.me

### Exceptions

Os recursos de manipulação de exceção da linguagem C# ajudam a lidar com quaisquer situações excepcionais ou inesperadas que ocorram quando um programa é executado.

### Lendo arquivos com C#

Ao ler um arquivo de texto, cada linha pode ser retornada em uma string. Utilizando a classe 'File', própria para a leitura de arquivos, através do método 'ReadAllLines' e passando o caminho do arquivo como argumento para o método, obtemos um array, no qual cada linha do arquivo é um elemento do array.

### Tratando uma exceção

O que é uma exceção? Uma exceção é um evento que ocorre durante a execução de um programa devido a uma situação anormal ou inesperada, como divisão por zero, tentativa de acessar um elemento de uma lista vazia, entre outros casos. É no tempo de execução (runtime) do programa que é interrompida a execução normal e dispara a exceção, quando isso ocorre deve haver um tratamento adequado para essa exceção ou o programa será encerrado e as informações sobre o erro podem ser exibidas no console.

### Como evitar que o programa seja encerrado quando uma exceção acontecer?

Com o bloco TryCatch, o programador consegue tratar possíveis exceções geradas durante a execução do sistema sem encerrar o programa. Além disso, é possível exibir uma mensagem personalizada quando uma exceção ocorrer, facilitando a identificação do erro dentro do sistema.

O código que pode disparar uma exceção é colocado dentro de um bloco Try e, caso a exceção ocorra, ela é enviada para o bloco Catch, onde será tratada. Pode-se programar uma mensagem específica no console ou outro tipo de tratamento, mas o programa não é encerrado e as linhas abaixo serão executadas.

### Exceção Genérica e Exceção Específica

Exceções genéricas são representadas pela classe Exception, que contém o conjunto de exceções que determinado método poderá lançar. Exceções específicas são propriedades dessa classe presentes em cada método.

Isso pode ser explorado no bloco TryCatch para personalizar mensagens e facilitar a manutenção do código, evitando a exibição completa da stack trace quando se tem certeza da exceção que pode acontecer, além de evitar a interrupção da execução. Também é possível criar vários blocos Catch para diferentes exceções.

O finally é um bloco que acompanha o TryCatch e será executado independentemente de ocorrer ou não alguma exceção.

### Introdução a Filas em C#

Filas são estruturas de dados semelhantes às filas do nosso cotidiano. Assim como na vida real, as filas na programação seguem o princípio de que o primeiro elemento que entra é o primeiro a sair (First In, First Out - FIFO).

Para incluir elementos na fila, utiliza-se o método 'Enqueue', passando o elemento como argumento. Para remover elementos, utiliza-se o método 'Dequeue', que, nesse caso, não requer argumentos, pois removerá o primeiro elemento que entrou na fila. O método 'Dequeue' também retorna o elemento removido.

### Introdução a Pilhas em C#

Pilhas são estruturas de dados similares às pilhas que conhecemos na vida real, onde os itens empilhados ficam um sobre o outro. Isso implica que o item mais abaixo só será retirado quando os demais acima dele forem retirados primeiro (Last In, First Out - LIFO). O primeiro a entrar é o último a sair.

Para incluir elementos na pilha, utiliza-se o método 'Push', e para remover elementos, utiliza-se o método 'Pop', que também retorna o elemento removido. A remoção do 'Pop' ocorre sempre no último elemento que foi adicionado à pilha.

### Introdução ao Dictionary em C#

O Dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica. Caso exista uma chave duplicada, ele lança uma exceção.

O Dictionary garante a unicidade do valor pela chave. Ao declarar uma coleção Dictionary, é necessário especificar o tipo de dado da chave e dos elementos.

Para adicionar elementos a um Dictionary, utiliza-se o método 'Add', passando dois argumentos: a chave, que deve ser única, e o elemento.

Se o valor da chave for repetido, o Dictionary lançará uma exceção. O valor do elemento pode ser repetido, mas o da chave não.

Para remover elementos do Dictionary, utiliza-se o método 'Remove', passando a chave do elemento desejado como argumento.

Para realizar alterações ou acessar algo dentro do Dictionary, a referência será sempre a chave. O modo de manipulação é semelhante ao de um array, onde se chama o nome do array seguido de colchetes, e dentro dos colchetes está o valor da chave do elemento que se deseja acessar.

Para verificar se alguma chave existe no Dictionary, é possível utilizar o método 'ContainsKey', que retornará um valor booleano indicando se a chave foi encontrada ou não.
