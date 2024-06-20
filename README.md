# Grupo-de-Saude-e-Vida-SIM
Projeto de conclusão da UC  Sistemas Distribuídos e Mobile.
Grupo Saúde e Vida SIM - É um Sistema de Cadastro para Agendamento de Consultas Médicas.

Descrição

Este projeto é um sistema de cadastro de consultas para pacientes, desenvolvido utilizando Windows Forms com .NET (Visual Studio) e C#. 
O sistema permite fazer o CRUD Create (Criar), Read (Ler), Update (Atualizar) e Delete (Apagar), nos cadastrados dos pacientes, suas respectivas consultas médicas e médicos e além de usuários de login(autenticação).

A aplicação está conectada a um banco de dados MySQL utilizando XAMPP como servidor local.


Funcionalidades

    Cadastro de Consultas;
    Cadastro de pacientes; 
	Cadastro de médico;
    Consultas Agendadas;
    Dias de Atendimentos Médicos;
    Atualização e remoção de registros de pacientes, consultas e médicos;
    Busca de pacientes e consultas

Tecnologias Utilizadas

    Linguagem de Programação: C#
    Framework: .NET versão 4.7.2
    Interface Gráfica: Windows Forms (Visual Studio 2022)
    Banco de Dados: MySQL
    Servidor Local: XAMPP

Pré-requisitos

Para executar este projeto, você precisará ter o seguinte instalado em seu ambiente de desenvolvimento:

    .NET Framework
    Visual Studio (ou outro IDE de sua preferência)
    XAMPP (para o servidor MySQL)
	MySQL.Data (pacote instalado no NuGet) 

Instalação

Clonar o Repositório

git clone https://github.com/ThalysonSilva/Grupo-de-Saude-e-Vida-SIM.git

Configuração do Banco de Dados

    Inicie o XAMPP e inicie os serviços Apache e MySQL.
    Abra o phpMyAdmin e crie um novo banco de dados chamado clinica.
    Importe o arquivo clinica.sql localizado na pasta principal do projeto para configurar as tabelas necessárias.

Configuração do Projeto

    Abra o Visual Studio e carregue o projeto clonado.
    No arquivo App.config, atualize a string de conexão com as credenciais do seu banco de dados MySQL:


Executar a Aplicação

	Compile e execute o projeto no Visual Studio.
    A interface principal do sistema será carregada, permitindo que você comece a registrar pacientes, médico e consultas.
    Login: Administrador - Senha: 123

Uso
Tela de Cadastro de Pacientes

    Preencha os campos de informações do paciente.
    Clique em "Salvar" para registrar o paciente no banco de dados.

Tela de Agendamento de Consultas

    Selecione um paciente existente.
    Preencha os detalhes da consulta (data, hora, médico, etc.).
    Clique em "Agendar" para salvar a consulta.

Atualização e Exclusão

    Use os formulários de busca para localizar um paciente ou consulta.
    Atualize os dados conforme necessário e salve as alterações.
    Para excluir um registro, selecione-o e clique em "Excluir".

Contribuição

    Faça um fork do projeto.
    Crie uma nova branch com a sua feature ou correção: git checkout -b minha-feature.
    Commit suas mudanças: git commit -m 'Adiciona minha nova feature'.
    Faça um push para a branch: git push origin minha-feature.
    Envie um Pull Request.


Para dúvidas ou sugestões, entre em contato através do email: mpthalyson@gmail.com - jailtondayvidsilva@gmail.com - pollyana.eidelwein@gmail.com - agsouzab@gmail.com
