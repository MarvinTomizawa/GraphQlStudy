# GraphQlStudy
## Definição
GraphQL é uma query language para API. Onde é possivel habilitar "Declarative Data Fetching" que permite que o client escolha quais dados ele quer da API.<br>

Em vez de varios endpoints que retornam dados fixos é possivel, a partir de um squema de dados, utilizar apenas um endpoint onde é retornado dados específicos. <br>

Ele foi desenvolvido para dar mais flexibilidade e eficiencia entre a comunicação de cliente e servidor.

## Problemas com REST que motivou o surgimento da ferramenta:
- Muito tráfego de informação que não será utilizada diminuia a performance de aplicações mobile e/ou dispositivos com uma má sinal de internet.
- Necessidade de realizar mais de uma requests para montar telas mais complexas.
- Variedade de diferentes bibliotecas de frontend e plataformas client-side
- Menor velocidade de desenvolvimento.
- Menor aceitação a mudanças. Saidas de dados são "fixas", tendo qualquer alteração na estrutura do dado ser necessário realizar mudanças e redeploys.

## Root Types (Tipos de acesso ao servidor):
- <b>Query</b>: Estrutura que demonstra os dados desejados.
- <b>Mutation</b>: Queries para create, update e delete 
- <b>Subscription</b>: Conexão que é mantida aberta que permite o servidor enviar para o cliente dados no momento que ele foi criado, assim gerando atualização em tempo real.
- <b>Resolvers</b>: Função que sabe o que fazer com uma query, mapeada para um recurso específico.

## Vantagens:
- Diminui quantidade de dados que são transferidos pela rede, buscando apenas as informações necessárias.
- Resolve o problema de precisar de mais de um end-point para montar telas complexas.
- Diminui a quantidade de re-compilações a cada alteração da estrutura de dados, facilitando no desenvolvimento na hora de experimentar novas telas/estruturas.
- Updates em tempo real com subscriptions.

## Desvantagens:
- Aumenta a complexidade.
- Atribui responsabilidade ao front de enviar a estrutura que se é desejada.
- Maior gerenciamento de infraestrutura.

## Funcionamento:
- É realizado uma request POST para o servidor do GraphQL com uma query no body da request.