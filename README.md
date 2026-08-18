# Clinicall-System
# 🏥 Clinicall — Sistema de Gestão e Agendamento para Clínicas

Sistema desktop desenvolvido em **VB.NET** para gerenciamento completo de clínicas e consultórios médicos, com controle de usuários, agendamento de consultas e pagamento.

## Sobre o projeto

O Clinicall foi criado para resolver um problema comum em pequenas clínicas: a falta de um sistema simples e acessível para organizar o cadastro de pacientes/médicos e a agenda de consultas, sem depender de planilhas ou papel.

O sistema permite que administradores cadastrem médicos e pacientes, e que os agendamentos sejam feitos de forma visual, considerando a grade de horários de cada médico e evitando conflitos de agenda automaticamente.

## Funcionalidades

- **Login com dois perfis de acesso** (Administrador e Paciente), com bloqueio de usuários inativos
- **Cadastro de usuários** (pacientes), com edição e exclusão via grid interativo
- **Agendamento de consultas**:
  - Filtro por especialidade e médico
  - Geração automática de horários disponíveis com base na grade semanal de cada médico
  - Bloqueio de horários já ocupados
  - Busca de paciente por CPF ou login
- **Pagamento de consulta** para pacientes particulares
- Interface dividida em `UserControls`, permitindo navegação fluida entre telas dentro do menu principal

> **Nota sobre escopo:** por decisão de escopo (orientada pelo levantamento de requisitos do projeto acadêmico), o cadastro de médicos e a configuração da grade de horários são administrados diretamente no banco de dados, enquanto o fluxo de cadastro de pacientes e agendamento — o núcleo de uso do sistema — possui interface completa.

## Capturas de tela

**Tela de Login**
![Tela de login](screenshots/login.png)

**Menu Principal**
![Menu principal](screenshots/menu.png)

**Cadastro de Usuários**
![Cadastro de usuários](screenshots/cadastro.png)

**Agendamento de Consulta**
![Agendamento de consulta](screenshots/mconsulta.png)

**Consultas Marcadas**
![Consultas marcadas](screenshots/consultam.png)

## Tecnologias utilizadas

- **Linguagem:** VB.NET (.NET Framework, Windows Forms)
- **Banco de dados:** Microsoft Access (via ADODB/OLE DB)
- **Componentes de UI:** DataGridView, FlowLayoutPanel, UserControls customizados

## Como executar

### Pré-requisitos
- Visual Studio 2019 ou superior
- .NET Framework instalado
- Microsoft Access Database Engine (para leitura do arquivo `.mdb`)

### Passo a passo
1. Clone o repositório:
   ```bash
   git clone https://github.com/biaaaa41602/Clinicall-System.git
   ```
2. Abra o arquivo `proj_engsoft1.sln` no Visual Studio
3. Verifique se o banco de dados Access (`cad_med.mdb`) está na pasta `access/`, dentro do diretório de execução do projeto
4. Compile e execute o projeto (F5)

## Melhorias futuras

Este projeto foi desenvolvido durante a graduação com foco em praticar lógica de programação e estrutura de um sistema real. Pontos identificados para uma próxima versão, já mapeados:

- [ ] Migrar armazenamento de senhas para hash (ex: BCrypt) em vez de texto puro
- [ ] Substituir concatenação de SQL por queries parametrizadas, reforçando a proteção contra SQL Injection
- [ ] Mover credenciais de banco de dados para variáveis de ambiente/arquivo de configuração fora do controle de versão
- [ ] Migrar o banco de dados de Access para SQL Server ou PostgreSQL
- [ ] Centralizar a lógica de conexão com o banco (hoje duplicada em mais de uma tela)

## Licença

Este projeto está sob a licença MIT — veja o arquivo [LICENSE.txt](LICENSE.txt) para mais detalhes.

## Autora

Desenvolvido por **Beatriz Stênico** como projeto prático de Engenharia de Software.

- GitHub: [@biaaaa41602](https://github.com/biaaaa41602)
- LinkedIn: [beatriz-stenico](https://www.linkedin.com/in/beatriz-stenico-ba3aa0321)
