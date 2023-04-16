- Quando o usuário abrir a aplicação deve ser solicitado qual o formato de data ele deseja visualizar. Deve ser disponibilizada as formatações abaixo:

1. Utilizar minha configuração de sistema: 08/01/2021 20:48:13 (Este item deve apenas converter a data para string, deixar que o sistema use o formato dele)
2. Formato simples: 08-01-21
3. Formato longo sexta-feira, 8 de janeiro de 2021
4. Formato longo personalizado 08-01-2021 08:48:13
5. Formato RFC1123 pattern Fri, 08 Jan 2021 20:48:13 GMT

- Você deverá mostrar as datas conforme os formatos nos exemplos acima. Siga as dicas abaixo:
  - Estude como usar o `string.Format` para personalizar o formato da data.
  - Estude as conversões para string específicas para `DateTime`.
  - Para o item 5, verifique como aplicar o formato RFC1123Pattern para o `DateTime`.
- Na seleção do formato da data, valide a opção e exiba uma mensagem caso não esteja entre 1 e 5 conforme opções do primeiro requisito, e volte para o menu da seleção do formato da data para que o usuário tente novamente.

- Após seleção correta de uma opção exiba um segundo menu com as seguintes opções (ou use outras de sua escolha):
  1- ENIAC
  2- RFC1
  3- Alan Turing

- Ao escolher uma das opções o sistema deverá exibir para o usuário um cabeçalho com a data do evento e um texto com a descrição do evento. Abaixo você encontra as datas e textos dos eventos sugeridos acima:

**(ENIAC) - 15 de agosto de 1946**
No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.

**(RFC1) - 17 de abril de 1969**
Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.

**(Alan Turing) - 23 de junho de 1912**
Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o "pai da informática" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.
