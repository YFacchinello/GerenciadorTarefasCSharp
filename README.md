# Gerenciador de Tarefas em C#

Projeto console desenvolvido para fins de estudo da linguagem C# e dos conceitos de Orientação a Objetos, parte do meu portfólio de estudante de Análise e Desenvolvimento de Sistemas.

## Funcionalidades
- **Adicionar Tarefas:** Criação de novos itens com descrição.
- **Listagem Dinâmica:** Visualização de todas as tarefas cadastradas.
- **Checklist:** Marcar tarefas como concluídas com alteração visual (`[ ]` para `[X]`).
- **Persistência de Dados:** Os dados são salvos automaticamente em um arquivo `.txt`, permitindo fechar e abrir o programa sem perder o progresso.

## Conceitos Aplicados
- **Orientação a Objetos:** Uso de classes, construtores e métodos.
- **Manipulação de Arquivos (I/O):** Leitura e escrita com `System.IO`.
- **Coleções Genéricas:** Uso de `List<T>` para gerenciamento dinâmico de memória.
- **Tratamento de Dados:** Validação de entradas com `int.TryParse`.

## Como executar
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone o repositório.
3. No terminal, execute:
   ```bash
   dotnet run
