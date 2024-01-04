-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.11.2-MariaDB
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.5.0.6677
-- --------------------------------------------------------

CREATE DATABASE IF NOT EXISTS `checklistcqp`
USE `checklistcqp`;

CREATE TABLE IF NOT EXISTS `requisitos` (
  `id_Requisito` int(11) NOT NULL,
  `id_Tarefa` int(11) NOT NULL,
  `finalizado` tinyint(1) DEFAULT 0,
  `BugRelacionado` int(11) DEFAULT NULL,
  `Observacao` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_Requisito`,`id_Tarefa`),
  KEY `id_Tarefa` (`id_Tarefa`),
  CONSTRAINT `requisitos_ibfk_1` FOREIGN KEY (`id_Tarefa`) REFERENCES `tarefas` (`id_Tarefa`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

CREATE TABLE IF NOT EXISTS `tarefas` (
  `id_Tarefa` int(11) NOT NULL,
  `nome_Testador` varchar(25) NOT NULL,
  `tela` varchar(100) DEFAULT NULL,
  `dataHora_inicio` datetime DEFAULT NULL,
  `dataHora_fim` datetime DEFAULT NULL,
  `post_forum` varchar(100) DEFAULT NULL,
  `finalizada` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`id_Tarefa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

CREATE TABLE IF NOT EXISTS `testadores` (
  `nome` varchar(25) NOT NULL,
  `senha` varchar(25) NOT NULL,
  PRIMARY KEY (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;
