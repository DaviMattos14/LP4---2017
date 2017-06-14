-- --------------------------------------------------------
-- Servidor:                     localhost
-- Versão do servidor:           5.7.17-log - MySQL Community Server (GPL)
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para test
CREATE DATABASE IF NOT EXISTS `test` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `test`;

-- Copiando estrutura para tabela test.carros
CREATE TABLE IF NOT EXISTS `carros` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Dono` varchar(50) DEFAULT NULL,
  `Placa` varchar(50) DEFAULT NULL,
  `Modelo` varchar(50) DEFAULT NULL,
  `Ano` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela test.carros: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `carros` DISABLE KEYS */;
INSERT INTO `carros` (`ID`, `Dono`, `Placa`, `Modelo`, `Ano`) VALUES
	(5, 'Davi', 'LOL201', 'Fiesta', 2013),
	(6, 'Lucas', 'IKR2013', 'Audi', 2011),
	(7, 'Ursula', 'LAS2012', 'Harley', 2017);
/*!40000 ALTER TABLE `carros` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
