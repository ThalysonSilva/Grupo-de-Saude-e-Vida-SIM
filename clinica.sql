-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16/06/2024 às 20:56
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

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
  `valorDaConsulta` double DEFAULT NULL,
  `dataDaConsulta` date DEFAULT NULL,
  `nomeDaClinica` varchar(32) DEFAULT NULL,
  `tipoDaConsulta` varchar(32) DEFAULT NULL,
  `nome` varchar(32) DEFAULT NULL,
  `especialidade` varchar(32) DEFAULT NULL,
  `nomeDoMedico` varchar(32) DEFAULT NULL,
  `horarioDaConsulta` varchar(32) DEFAULT NULL,
  `crm` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `consulta`
--

INSERT INTO `consulta` (`id`, `valorDaConsulta`, `dataDaConsulta`, `nomeDaClinica`, `tipoDaConsulta`, `nome`, `especialidade`, `nomeDoMedico`, `horarioDaConsulta`, `crm`) VALUES
(1, 555, '2025-12-25', 'Clínica Saúde e Vida', 'Consulta Eletiva', 'ANGELO BARROS', 'Reumatologia', 'JOÃO SANTOS SILVA', '', 121212),
(2, 5555, '2028-12-25', 'Clínica São José', 'Urgência', 'JIUSEPPE', 'Reumatologia', 'JOÃO SANTOS SILVA', '', 121212),
(3, 1500, '2026-07-29', 'Clínica Bem Estar', 'Urgência', 'ANGELO BARROS', 'Reumatologia', 'JOÃO SANTOS SILVA', '14:00H - 16:00H ', 121212),
(4, 1522, '2027-12-25', 'Clínica São José', 'Consulta Eletiva', 'ANGELO BARROS', 'Reumatologia', 'JOÃO SANTOS SILVA', '14:00H - 16:00H ', 121212);

-- --------------------------------------------------------

--
-- Estrutura para tabela `medico`
--

CREATE TABLE `medico` (
  `id` int(11) NOT NULL,
  `nome` varchar(80) DEFAULT NULL,
  `crm` int(10) DEFAULT NULL,
  `especialidade` varchar(20) DEFAULT NULL,
  `diaDeAtendimento` varchar(32) DEFAULT NULL,
  `horarioAtendimento` varchar(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `medico`
--

INSERT INTO `medico` (`id`, `nome`, `crm`, `especialidade`, `diaDeAtendimento`, `horarioAtendimento`) VALUES
(1, 'JOSE ALDO', 11111, 'HEMATOLOGIA', '0000-00-00 00:00:00', '0000-00-00'),
(2, 'JOSE ALDO', 11111, 'HEMATOLOGIA', 'TERÇA-FEIRA', '14:00H - 18:00H '),
(3, 'JOÃO SANTOS SILVA', 121212, 'REUMATOLOGIA', 'SEGUNDA A SÁBADO', '14:00H - 16:00H ');

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
(1, 'qweqweqwe', '123,123,123', '(31) 23123-1', '1753-01-01', '12312-312', 'asdasdasdasd', 12, 'asdasdas', 'dasdasda', 'RN'),
(2, 'thalyson teste', '123,123,123', '(12) 31231-2', '1753-01-01', '12312-312', 'rua nova', 23, 'Mãe luiza', 'Natal', 'RN'),
(3, 'jailton test', '123,123,121', '(12) 31231-2', '1956-06-28', '12312-312', 'qsadqwdqwdq', 12, 'asdasd', 'sdasdasd', 'RN'),
(4, 'qweeqweqw', '123,123,123', '(12) 31231-2', '1996-09-28', '12312-312', 'asdasdasda', 12, 'asduhaius as', 'asdjahsdu', 'RN'),
(5, 'daqwdqwdqwddqwdqwdqwd21', '123,123,123', '(12) 31231-2', '3123-12-23', '12312-312', 'addawdaw', 22, 'asdasda', 'wdqdqwdqwd', 'RN'),
(6, 'teste', '134,342,352', '(23) 52352-3', '2000-12-12', '23523-523', 'fsdfsdfsd', 23, 'ml', 'natal', 'RN'),
(7, 'addasd', '123,123,123-12', '(12) 31231-2', '2000-02-02', '12312-312', 'sdasdasdasda', 12, 'asdasdas', 'dasdasdasd', 'RN'),
(8, 'dasdasdasd', '123,123,123-12', '(12) 31231-2', '2000-02-11', '12312-312', 'dasda sda', 12, 'asdasda ', 'asdasdasda', 'RN'),
(9, 'fwefwefwe', '123,123,123-12', '(12) 31231-2', '2000-02-12', '32312-312', 'dasda wd', 32, 'adasdasd', 'sdasdasdas', 'RN'),
(10, 'wfwefwefw', '123,123,123-12', '(12) 31231-2312', '2000-02-12', '12312-312', 'asdasdas', 123, 'asdasd', 'asdasdas', 'rd'),
(11, 'cscsdcsdcsdcs', '123,123,123-12', '(12) 31231-2312', '1996-11-12', '12312-312', 'asdasdasd', 12, 'asdaf', 'fadfasd', 'rn'),
(12, 'asdasfasfa', '123,123,123-12', '(12) 31231-2312', '2000-02-02', '12312-312', 'sadasfa', 12, 'asdkjalbs', 'dajsdnaiusb', 'RN'),
(13, 'fwwefwe', '123,123,123-12', '(12) 31231-2312', '2000-02-11', '12312-312', 'wdqwdqwdqwd', 45, 'asdafaf', 'afsasfas', 'rn'),
(14, 'adsdasdasdas', '151,616,515-61', '(12) 31231-2312', '2000-02-12', '11111-111', 'dasdasda', 12, 'sdasdasda', 'asdasdas', 'RN'),
(15, 'asdasda', '123,123,123-12', '(12) 31231-2312', '2000-02-12', '12312-312', 'asdasdiasbdi', 32, 'sdasdasd', 'asdasdas', 'RN'),
(16, 'asdasda', '123,123,123-12', '(12) 31231-2312', '2000-02-12', '12312-312', 'asdasdiasbdi', 32, 'sdasdasd', 'asdasdas', 'RN'),
(17, 'asdasdasd', '123,123,123-12', '(12) 31231-2312', '2000-02-12', '31231-231', 'asd asdasd', 21, 'ad sda', 'asdasda', 'Rn'),
(18, 'Jailton Dayvid', '111,111,111-11', '(84) 95955-9959', '1988-12-09', '11111-111', 'RUA TEST', 14, 'BAIRRO TESTE', 'natal', 'RN'),
(19, 'ANGELO BARROS', '11111111111', '(88) 88888-8888', '2000-07-29', '59151-660', 'RUA DAS MANGUEIRAS', 1, 'NOVA PARNAMIRIM', 'PARNAMIRIM', 'RN'),
(20, 'JIUSEPPE', '55555555555', '(12) 12121-2121', '2002-07-29', '59151-660', 'RUA DAS MANGUEIRAS', 25, 'NOVA PARNAMIRIM', 'PARNAMIRIM', 'RN');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `confsenha` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuario`
--

INSERT INTO `usuario` (`id`, `usuario`, `senha`, `confsenha`) VALUES
(1, 'Administrador', '@dmin123', '@dmin123'),
(2, 'Jailton.Morais', '123', '123'),
(3, 'Jailton.Morais', 'Jd123', 'Jd123'),
(4, 'Teste 01', 'Teste01', 'Teste01'),
(5, 'Teste 02', '123', '123');

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
  ADD PRIMARY KEY (`id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `medico`
--
ALTER TABLE `medico`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `paciente`
--
ALTER TABLE `paciente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
