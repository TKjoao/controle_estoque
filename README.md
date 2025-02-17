Controle de Estoque - Sistema CRUD

Descrição
Este é um sistema simples de controle de estoque em C# que permite realizar as operações CRUD (Criar, Ler, Atualizar, Deletar) sobre produtos em estoque. O sistema é baseado em um menu interativo onde o usuário pode adicionar, visualizar, atualizar e remover produtos.

O código utiliza uma lista em memória para armazenar os dados dos produtos, sem a persistência em banco de dados.

Funcionalidades:
Criar (Adicionar Produto): Permite adicionar um novo produto ao estoque com informações como nome, quantidade e preço.
Ler (Exibir Estoque): Exibe a lista de todos os produtos presentes no estoque.
Atualizar (Modificar Produto): Permite atualizar o nome, quantidade ou preço de um produto existente.
Deletar (Remover Produto): Permite remover um produto do estoque utilizando seu ID.
Como Usar
Pré-requisitos
Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode baixar o .NET SDK aqui.

Passos para executar:
Clonar o Repositório

bash
Copiar
git clone https://github.com/TKjoao/controle_estoque.git
cd controle-estoque
Compilar e Rodar

Caso tenha o Visual Studio ou Visual Studio Code com a extensão C# instalada, basta abrir o projeto, compilar e rodar o programa.

Alternativamente, você pode rodar o código no terminal:

bash
Copiar
dotnet build
dotnet run
Interagir com o Sistema

Ao rodar o código, um menu interativo será exibido no console. Você pode escolher entre as opções para adicionar, atualizar, exibir ou deletar produtos do estoque.

Estrutura do Código
O código está dividido nas seguintes partes principais:

Classe Produto

Contém as propriedades do produto, como Id, Nome, Quantidade, e Preco.
Métodos para exibir as informações do produto.
Classe Estoque

Gerencia uma lista de objetos Produto.
Métodos para adicionar, exibir, atualizar e remover produtos do estoque.
Classe Program

Contém o menu interativo e a lógica principal do sistema.
Exemplo de Uso
Menu Inicial
Ao executar o programa, o seguinte menu será exibido no console:

nginx
Copiar
Sistema de Controle de Estoque
1 - Adicionar Produto
2 - Exibir Estoque
3 - Atualizar Produto
4 - Deletar Produto
5 - Sair
Escolha uma opção:
Exemplo de Entrada:
1. Adicionar Produto:
Nome: Camiseta
Quantidade: 100
Preço: 39.99
2. Exibir Estoque:
O estoque será exibido com todos os produtos cadastrados.

3. Atualizar Produto:
Escolha um produto pelo ID e atualize as informações (nome, quantidade, preço).

4. Deletar Produto:
Escolha um produto pelo ID e o remova do estoque.

Como Contribuir
Se você deseja contribuir para este projeto, basta seguir os seguintes passos:

Faça um fork do repositório.
Crie uma branch para sua alteração (git checkout -b minha-alteracao).
Faça as modificações e commit (git commit -m 'Adiciona nova funcionalidade').
Envie para o repositório remoto (git push origin minha-alteracao).
Abra um pull request.
