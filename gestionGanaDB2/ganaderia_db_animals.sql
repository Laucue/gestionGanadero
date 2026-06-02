-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: ganaderia_db
-- ------------------------------------------------------
-- Server version	9.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `animals`
--

DROP TABLE IF EXISTS `animals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animals` (
  `IdAnimal` int NOT NULL AUTO_INCREMENT,
  `EarringCode` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IdSpecies` int NOT NULL,
  `IdBreed` int DEFAULT NULL,
  `Sex` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BirthDate` datetime(6) DEFAULT NULL,
  `Status` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Color` varchar(80) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Notes` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IdFather` int DEFAULT NULL,
  `IdMother` int DEFAULT NULL,
  `IdLocation` int DEFAULT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UpdatedAt` datetime(6) NOT NULL,
  PRIMARY KEY (`IdAnimal`),
  KEY `IX_Animals_IdBreed` (`IdBreed`),
  KEY `IX_Animals_IdFather` (`IdFather`),
  KEY `IX_Animals_IdLocation` (`IdLocation`),
  KEY `IX_Animals_IdMother` (`IdMother`),
  KEY `IX_Animals_IdSpecies` (`IdSpecies`),
  CONSTRAINT `FK_Animals_Animals_IdFather` FOREIGN KEY (`IdFather`) REFERENCES `animals` (`IdAnimal`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Animals_Animals_IdMother` FOREIGN KEY (`IdMother`) REFERENCES `animals` (`IdAnimal`) ON DELETE RESTRICT,
  CONSTRAINT `FK_Animals_Breeds_IdBreed` FOREIGN KEY (`IdBreed`) REFERENCES `breeds` (`IdBreed`),
  CONSTRAINT `FK_Animals_Locations_IdLocation` FOREIGN KEY (`IdLocation`) REFERENCES `locations` (`IdLocation`),
  CONSTRAINT `FK_Animals_Species_IdSpecies` FOREIGN KEY (`IdSpecies`) REFERENCES `species` (`IdSpecies`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animals`
--

LOCK TABLES `animals` WRITE;
/*!40000 ALTER TABLE `animals` DISABLE KEYS */;
/*!40000 ALTER TABLE `animals` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-02  0:24:20
