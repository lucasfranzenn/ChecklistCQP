-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.11.2-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.5.0.6677
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para checklistcqp
CREATE DATABASE IF NOT EXISTS `checklistcqp` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;
USE `checklistcqp`;

-- Copiando estrutura para tabela checklistcqp.requisitos
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

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela checklistcqp.tarefas
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

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela checklistcqp.testadores
CREATE TABLE IF NOT EXISTS `testadores` (
  `nome` varchar(25) NOT NULL,
  `senha` varchar(25) NOT NULL,
  PRIMARY KEY (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

-- Exportação de dados foi desmarcado.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
