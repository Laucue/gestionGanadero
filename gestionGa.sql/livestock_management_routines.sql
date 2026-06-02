-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: livestock_management
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
-- Temporary view structure for view `vw_animals_complete`
--

DROP TABLE IF EXISTS `vw_animals_complete`;
/*!50001 DROP VIEW IF EXISTS `vw_animals_complete`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_animals_complete` AS SELECT 
 1 AS `animal_id`,
 1 AS `identification_code`,
 1 AS `species`,
 1 AS `breed`,
 1 AS `birth_date`,
 1 AS `age`,
 1 AS `gender`,
 1 AS `weight`,
 1 AS `health_status`,
 1 AS `status`,
 1 AS `location_name`,
 1 AS `area_hectares`,
 1 AS `mother_code`,
 1 AS `father_code`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_health_history`
--

DROP TABLE IF EXISTS `vw_health_history`;
/*!50001 DROP VIEW IF EXISTS `vw_health_history`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_health_history` AS SELECT 
 1 AS `animal_id`,
 1 AS `identification_code`,
 1 AS `record_date`,
 1 AS `record_type`,
 1 AS `detail_name`,
 1 AS `veterinarian_name`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_sales_report`
--

DROP TABLE IF EXISTS `vw_sales_report`;
/*!50001 DROP VIEW IF EXISTS `vw_sales_report`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_sales_report` AS SELECT 
 1 AS `sale_id`,
 1 AS `sale_date`,
 1 AS `buyer_name`,
 1 AS `identification_number`,
 1 AS `animal_code`,
 1 AS `species`,
 1 AS `breed`,
 1 AS `unit_price`,
 1 AS `total_amount`,
 1 AS `payment_method`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vw_animals_complete`
--

/*!50001 DROP VIEW IF EXISTS `vw_animals_complete`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_animals_complete` AS select `a`.`animal_id` AS `animal_id`,`a`.`identification_code` AS `identification_code`,`a`.`species` AS `species`,`a`.`breed` AS `breed`,`a`.`birth_date` AS `birth_date`,timestampdiff(YEAR,`a`.`birth_date`,curdate()) AS `age`,`a`.`gender` AS `gender`,`a`.`weight` AS `weight`,`a`.`health_status` AS `health_status`,`a`.`status` AS `status`,`l`.`location_name` AS `location_name`,`l`.`area_hectares` AS `area_hectares`,`m`.`identification_code` AS `mother_code`,`f`.`identification_code` AS `father_code` from (((`animals` `a` left join `locations` `l` on((`a`.`location_id` = `l`.`location_id`))) left join `animals` `m` on((`a`.`mother_id` = `m`.`animal_id`))) left join `animals` `f` on((`a`.`father_id` = `f`.`animal_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_health_history`
--

/*!50001 DROP VIEW IF EXISTS `vw_health_history`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_health_history` AS select `a`.`animal_id` AS `animal_id`,`a`.`identification_code` AS `identification_code`,`hr`.`record_date` AS `record_date`,`hr`.`record_type` AS `record_type`,(case `hr`.`record_type` when 'Vacuna' then `v`.`vaccine_name` when 'Tratamiento' then `t`.`medication_name` when 'Enfermedad' then `d`.`disease_name` when 'Chequeo' then `mc`.`checkup_type` end) AS `detail_name`,`hr`.`veterinarian_name` AS `veterinarian_name` from (((((`animals` `a` join `health_records` `hr` on((`a`.`animal_id` = `hr`.`animal_id`))) left join `vaccines` `v` on((`hr`.`health_record_id` = `v`.`health_record_id`))) left join `treatments` `t` on((`hr`.`health_record_id` = `t`.`health_record_id`))) left join `diseases` `d` on((`hr`.`health_record_id` = `d`.`health_record_id`))) left join `medical_checkups` `mc` on((`hr`.`health_record_id` = `mc`.`health_record_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_sales_report`
--

/*!50001 DROP VIEW IF EXISTS `vw_sales_report`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_sales_report` AS select `s`.`sale_id` AS `sale_id`,`s`.`sale_date` AS `sale_date`,`b`.`buyer_name` AS `buyer_name`,`b`.`identification_number` AS `identification_number`,`a`.`identification_code` AS `animal_code`,`a`.`species` AS `species`,`a`.`breed` AS `breed`,`sd`.`unit_price` AS `unit_price`,`s`.`total_amount` AS `total_amount`,`s`.`payment_method` AS `payment_method` from (((`sales` `s` join `buyers` `b` on((`s`.`buyer_id` = `b`.`buyer_id`))) join `sale_details` `sd` on((`s`.`sale_id` = `sd`.`sale_id`))) join `animals` `a` on((`sd`.`animal_id` = `a`.`animal_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-01 23:34:44
