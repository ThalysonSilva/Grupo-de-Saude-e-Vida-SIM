-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20/06/2024 às 03:10
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `clinica`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `consulta`
--

CREATE TABLE `consulta` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `nomeDaClinica` varchar(50) NOT NULL,
  `nomeDoMedico` varchar(50) NOT NULL,
  `crm` int(12) NOT NULL,
  `especialidade` varchar(32) NOT NULL,
  `tipoDaConsulta` varchar(32) DEFAULT NULL,
  `dataDaConsulta` date NOT NULL,
  `horarioDaConsulta` varchar(32) NOT NULL,
  `valorDaConsulta` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `consulta`
--

INSERT INTO `consulta` (`id`, `nome`, `nomeDaClinica`, `nomeDoMedico`, `crm`, `especialidade`, `tipoDaConsulta`, `dataDaConsulta`, `horarioDaConsulta`, `valorDaConsulta`) VALUES
(1, 'THALYSON SILVA', 'Clínica Saúde e Vida', 'ANTONIO MENDES SILVA', 1524, 'Cardiologia', 'Consulta Eletiva', '2024-06-20', '7:00H - 11:00H', 150),
(2, 'THALYSON SILVA', 'Clínica São José', 'RAIMUNDO OLIVEIRA DA COSTA', 2415, 'Cardiologia', 'Exames', '2024-07-11', '7:00H - 12:00H', 230),
(3, 'JAILTON DEIVID MORAIS', 'Clínica Saúde e Vida', 'RAIMUNDA MARQUES SIQUEIRA', 5324, 'Gastroenterologia', 'Urgência', '2024-06-20', '14:00H - 17:00H ', 452),
(4, 'JAILTON DEIVID MORAIS', 'Clínica São José', 'FABIO DOS SANTOS', 1145, 'CARDIOLOGIA', 'Consulta Eletiva', '2024-06-19', '7:00H - 10:00H', 200),
(5, 'THALYSON SILVA', 'Clínica São José', 'RAIMUNDO OLIVEIRA DA COSTA', 2415, 'Cardiologia', 'Exames', '2024-07-11', '14:00H - 17:00H ', 230),
(6, 'ANGELO LEONOR MARINHO', 'Clínica São José', 'FABIO DOS SANTOS', 1145, 'Cardiologia', 'Consulta Eletiva', '2024-11-11', '7:00H - 10:00H', 124),
(7, 'JAILTON DEIVID MORAIS', 'Clínica São José', 'FABIO DOS SANTOS', 1145, 'Cardiologia', 'Consulta Eletiva', '2024-06-19', '7:00H - 10:00H', 150);

-- --------------------------------------------------------

--
-- Estrutura para tabela `medico`
--

CREATE TABLE `medico` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `crm` int(10) NOT NULL,
  `especialidade` varchar(32) DEFAULT NULL,
  `diaDeAtendimento` varchar(32) DEFAULT NULL,
  `horarioAtendimento` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `medico`
--

INSERT INTO `medico` (`id`, `nome`, `crm`, `especialidade`, `diaDeAtendimento`, `horarioAtendimento`) VALUES
(1, 'ANTONIO MENDES SILVA', 1524, 'Cardiologia', 'Segunda-feira', '7:00h - 11:00h'),
(2, 'RAIMUNDO OLIVEIRA DA COSTA', 2415, 'CARDIOLOGIA', 'TERÇA-FEIRA', '7:00H - 12:00H'),
(3, 'RAIMUNDA MARQUES SIQUEIRA', 5324, 'GASTROENTEROLOGIA', 'TERÇA-FEIRA', '14:00H - 17:00H '),
(4, 'FABIO DOS SANTOS', 1145, 'CARDIOLOGIA', 'SEGUNDA A SÁBADO', '7:00H - 10:00H'),
(5, 'FRANCISCO FERNANDES SANTOS', 1245, 'GERIATRIA', 'SEGUNDA-FEIRA', '7:00H - 12:00H');

-- --------------------------------------------------------

--
-- Estrutura para tabela `paciente`
--

CREATE TABLE `paciente` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `contato` varchar(20) DEFAULT NULL,
  `dataNasc` date DEFAULT NULL,
  `cep` varchar(11) DEFAULT NULL,
  `endereco` varchar(50) DEFAULT NULL,
  `numCasa` int(6) DEFAULT NULL,
  `bairro` varchar(20) DEFAULT NULL,
  `cidade` varchar(20) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `paciente`
--

INSERT INTO `paciente` (`id`, `nome`, `cpf`, `contato`, `dataNasc`, `cep`, `endereco`, `numCasa`, `bairro`, `cidade`, `uf`) VALUES
(1, 'THALYSON SILVA', '23425367889', '(84) 98876-5398', '1996-09-28', '59014-210', 'RUA ANTÔNIO FÉLIX', 354, 'MÃE LUIZA', 'FORTALEZA', 'CE'),
(2, 'JAILTON DEIVID MORAIS', '45687525998', '(84) 91546-1681', '1980-02-02', '59114-460', 'RUA MORRO DA PEDRA', 24, 'NOSSA SENHORA DA APR', 'NATAL', 'RN'),
(3, 'ANGELO LEONOR MARINHO', '45615161861', '(84) 92426-5482', '1990-10-02', '59056-180', 'RUA DOUTOR POTY NÓBREGA', 20, 'LAGOA NOVA', 'NATAL', 'RN');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `confsenha` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`id`, `usuario`, `senha`, `confsenha`) VALUES
(1, 'Administrador', '123', '123');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `consulta`
--
ALTER TABLE `consulta`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `medico`
--
ALTER TABLE `medico`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `crm` (`crm`);

--
-- Índices de tabela `paciente`
--
ALTER TABLE `paciente`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `consulta`
--
ALTER TABLE `consulta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `medico`
--
ALTER TABLE `medico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `paciente`
--
ALTER TABLE `paciente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
