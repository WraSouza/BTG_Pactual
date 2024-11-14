<img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" target="_blank"> <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" target="_blank"> <img src="https://img.shields.io/badge/SQLite-07405E?style=for-the-badge&logo=sqlite&logoColor=white" target="_blank"><img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" target="_blank">


## Sobre a aplicação
Projeto desenvolvido para teste técnico. O projeto foi desenvolvido utilizando .NET MAUI e utilizando a abordagem MVVM com injeção de dependência.
A aplicação possui as seguintes funções: cadastro de clientes, alteração e exclusão. Possui também validação dos campos para que um cliente não seja cadastrado com os campos vazios.

# Pacotes utilizados
  <table>
    <tr>
      <td>CommunityToolkit.MVVM</td>
      <td>CommunityToolkit.Maui</td>
      <td>SQLite-net-pcl</td>
      <td>Flunt</td>
    </tr>
    <tr>
      <td>8.3.2</td>
      <td>9.1.1</td>
      <td>1.9.172</td>
      <td>2.0.5</td>
    </tr>
  </table>

# Utilização
Faça um clone do repositório para seu computador pessoal. Em seguinda, com uma IDE ( Visual Studio, VS Code ) abra a pasta onde o clone do repositório foi baixado e abra a solução.

Ao rodar a aplicação, a tela inicial será exibida. Nesta tela é possível visualizar os clientes cadastrados. Para se adicionar um usuário, deverá ser clicado no botão "+" no canto inferior direito.

![TelaInicial](https://github.com/user-attachments/assets/c1d2e274-6a6b-4615-8130-9574055b376a)

Após clicar no botão, a aplicação abrirá o formulário que deverá ser preenchido.

![Adicionar](https://github.com/user-attachments/assets/6a9ab340-0adb-42d3-a6bc-e41b0f30409f)

Após cadastrar um cliente, a aplicação retornará para a tela inicial. Após isso, deverá ser utilizando um refresh na tela, realizando um "pull to refresh", ou seja, fazendo um movimento na tela para baixo. Assim a tela será atualizada com os dados que estiverem no banco.

![TelaInicialPreenchida](https://github.com/user-attachments/assets/d3d0e392-53a3-4308-a194-ed0d6500aad3)

Clicando em um dos clientes exibidos na tela, a aplicação abrirá a tela para atualizar ou excluir o cliente selecionado.

![EditarCliente](https://github.com/user-attachments/assets/c5303959-f340-4e91-baee-b38304113cb6)

Faça as alteração necessárias nos campos informados e selecione "Alterar".

Caso a opção de excluir seja selecionada, a aplicação perguntará se deseja realmente excluir o cliente.

![ExcluirCliente](https://github.com/user-attachments/assets/5dc8129c-1942-44c4-81ab-0db1f8556f23)







