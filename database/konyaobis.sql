-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: obiskonya
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `araclar`
--

DROP TABLE IF EXISTS `araclar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `araclar` (
  `arac_id` int NOT NULL AUTO_INCREMENT,
  `arac_plaka` varchar(45) NOT NULL,
  `arac_cinsi` varchar(45) NOT NULL,
  `kullanicilar_kullanici_id` int NOT NULL,
  PRIMARY KEY (`arac_id`,`kullanicilar_kullanici_id`),
  KEY `fk_araclar_kullanicilar1_idx` (`kullanicilar_kullanici_id`),
  CONSTRAINT `fk_araclar_kullanicilar1` FOREIGN KEY (`kullanicilar_kullanici_id`) REFERENCES `kullanicilar` (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `araclar`
--

LOCK TABLES `araclar` WRITE;
/*!40000 ALTER TABLE `araclar` DISABLE KEYS */;
INSERT INTO `araclar` VALUES (1,'28DC013','Otomobil',1),(2,'42BIG69','Kamyonet',1),(3,'42CEB16','Otomobil',2),(4,'42YEK23','Otomobil',2),(5,'42YEK66','Otomobil',2),(6,'26VZ125','Kamyonet',1),(8,'42FLM42','Otomobil',4),(9,'42FLN42','Otomobil',4);
/*!40000 ALTER TABLE `araclar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kayitlar`
--

DROP TABLE IF EXISTS `kayitlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kayitlar` (
  `kayit_id` int NOT NULL AUTO_INCREMENT,
  `kayit_girissaat` varchar(45) NOT NULL,
  `kayit_cikissaat` varchar(45) DEFAULT NULL,
  `otoparklar_otopark_id` int NOT NULL,
  `araclar_arac_id` int NOT NULL,
  `araclar_kullanicilar_kullanici_id` int NOT NULL,
  `kayit_tarih` varchar(45) NOT NULL,
  PRIMARY KEY (`kayit_id`,`otoparklar_otopark_id`,`araclar_arac_id`,`araclar_kullanicilar_kullanici_id`),
  KEY `fk_kayitlar_otoparklar1_idx` (`otoparklar_otopark_id`),
  KEY `fk_kayitlar_araclar1_idx` (`araclar_arac_id`,`araclar_kullanicilar_kullanici_id`),
  CONSTRAINT `fk_kayitlar_araclar1` FOREIGN KEY (`araclar_arac_id`, `araclar_kullanicilar_kullanici_id`) REFERENCES `araclar` (`arac_id`, `kullanicilar_kullanici_id`),
  CONSTRAINT `fk_kayitlar_otoparklar1` FOREIGN KEY (`otoparklar_otopark_id`) REFERENCES `otoparklar` (`otopark_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kayitlar`
--

LOCK TABLES `kayitlar` WRITE;
/*!40000 ALTER TABLE `kayitlar` DISABLE KEYS */;
INSERT INTO `kayitlar` VALUES (1,'22:29','22:30',5,1,1,'28.05.2022'),(2,'20:33','21:28',4,1,1,'28.05.2022'),(3,'00:43','6:39',4,2,1,'29.05.2022'),(4,'00:43','5:14',8,2,1,'29.05.2022'),(5,'01:07','5:52',4,1,1,'29.05.2022'),(6,'01:16','3:0',4,3,2,'29.05.2022'),(7,'01:16','2:35',9,4,2,'29.05.2022'),(8,'04:44','5:52',4,1,1,'29.05.2022'),(10,'06:25','8:33',7,8,4,'29.05.2022'),(11,'06:26','12:15',7,9,4,'29.05.2022');
/*!40000 ALTER TABLE `kayitlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kullanicilar`
--

DROP TABLE IF EXISTS `kullanicilar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanicilar` (
  `kullanici_id` int NOT NULL AUTO_INCREMENT,
  `kullanici_tc` varchar(45) NOT NULL,
  `kullanici_sifre` varchar(45) NOT NULL,
  `kullanici_adsoyad` varchar(45) DEFAULT NULL,
  `kullanici_mail` varchar(45) NOT NULL,
  PRIMARY KEY (`kullanici_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanicilar`
--

LOCK TABLES `kullanicilar` WRITE;
/*!40000 ALTER TABLE `kullanicilar` DISABLE KEYS */;
INSERT INTO `kullanicilar` VALUES (1,'54844255232','123','Sait KOCABAŞ','sait@gmail.com'),(2,'11363704566','1','Yusuf Emre Karanfil','1'),(4,'40480739410','123','Necmettin','ncl@gmail.com');
/*!40000 ALTER TABLE `kullanicilar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odemeler`
--

DROP TABLE IF EXISTS `odemeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odemeler` (
  `kayitlar_kayit_id` int NOT NULL,
  `kayitlar_otoparklar_otopark_id` int NOT NULL,
  `araclar_arac_id` int NOT NULL,
  `araclar_kullanicilar_kullanici_id` int NOT NULL,
  `odendimi` varchar(45) NOT NULL,
  `ucret` varchar(45) NOT NULL,
  PRIMARY KEY (`kayitlar_kayit_id`,`kayitlar_otoparklar_otopark_id`,`araclar_arac_id`,`araclar_kullanicilar_kullanici_id`),
  KEY `fk_kayitlar_has_araclar_araclar1_idx` (`araclar_arac_id`,`araclar_kullanicilar_kullanici_id`),
  KEY `fk_kayitlar_has_araclar_kayitlar1_idx` (`kayitlar_kayit_id`,`kayitlar_otoparklar_otopark_id`),
  CONSTRAINT `fk_kayitlar_has_araclar_araclar1` FOREIGN KEY (`araclar_arac_id`, `araclar_kullanicilar_kullanici_id`) REFERENCES `araclar` (`arac_id`, `kullanicilar_kullanici_id`),
  CONSTRAINT `fk_kayitlar_has_araclar_kayitlar1` FOREIGN KEY (`kayitlar_kayit_id`, `kayitlar_otoparklar_otopark_id`) REFERENCES `kayitlar` (`kayit_id`, `otoparklar_otopark_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odemeler`
--

LOCK TABLES `odemeler` WRITE;
/*!40000 ALTER TABLE `odemeler` DISABLE KEYS */;
INSERT INTO `odemeler` VALUES (2,4,1,1,'EVET','20,9'),(3,4,2,1,'EVET','35,6'),(4,8,2,1,'EVET','27,1'),(5,4,1,1,'EVET','6,8'),(6,4,3,2,'HAYIR','10,4'),(7,9,4,2,'HAYIR','7,9'),(10,7,8,4,'EVET','12,8'),(11,7,9,4,'EVET','35');
/*!40000 ALTER TABLE `odemeler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `otoparklar`
--

DROP TABLE IF EXISTS `otoparklar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `otoparklar` (
  `otopark_id` int NOT NULL AUTO_INCREMENT,
  `otopark_adi` varchar(100) NOT NULL,
  `otopark_adres` varchar(45) NOT NULL,
  `otopark_konumlink` varchar(500) NOT NULL,
  `otopark_kapasite` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`otopark_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `otoparklar`
--

LOCK TABLES `otoparklar` WRITE;
/*!40000 ALTER TABLE `otoparklar` DISABLE KEYS */;
INSERT INTO `otoparklar` VALUES (1,'ZİNDANKALE','MERKEZ','https://www.google.com/maps/place/%C4%B0hsaniye,+H%C3%BCsn%C3%BC+A%C5%9Fk+Sk.,+42060+Sel%C3%A7uklu%2FKonya/@37.8733401,32.4868676,18.75z/data=!4m5!3m4!1s0x14d085a8c1f3b815:0x6636a048d6a392fb!8m2!3d37.8733556!4d32.4878033','20'),(2,'MERAM BÖLGE OTOPARKI','MERAM','https://www.google.com/maps/place/Otopark/@37.8526545,32.4180234,17z/data=!4m5!3m4!1s0x14d086cda58a8123:0x7c35b886107a4cf2!8m2!3d37.8524603!4d32.4148329','636'),(3,'KONEVİ BÖLGE OTOPARKI ','KARATAY','https://www.google.com/maps/place/Konevi+Katl%C4%B1+Otopark%C4%B1/@37.8718723,32.4848589,16.75z/data=!4m9!1m2!2m1!1sKONEV%C4%B0+KAPALI!3m5!1s0x14d085abf78567bd:0xfe965fc55cd5a8ab!8m2!3d37.8696286!4d32.4865596!15sCg5LT05FVsSwIEtBUEFMSVoPIg1rb25ldmkga2FwYWxpkgEEY2FmZQ','297'),(4,'İPLİKÇİ BÖLGE OTOPARKI','KARATAY','https://www.google.com/maps/search/%C4%B0PL%C4%B0K%C3%87%C4%B0+otopark/@37.8718068,32.496231,19.25z','250'),(5,'MEVLANA ÇARŞI KATLI OTOPARKI','KARATAY','https://www.google.com/maps/place/Mevlana+Otopark/@37.8711226,32.5026414,17.5z/data=!4m9!1m2!2m1!1sMEVLANA+%C3%87AR%C5%9EI+KATLI+OTOPARKI!3m5!1s0x14d08510593c37a3:0xfd874a6f2b5f82da!8m2!3d37.8708202!4d32.505965!15sCh5NRVZMQU5BIMOHQVLFnkkgS0FUTEkgT1RPUEFSS0mSAQtwYXJraW5nX2xvdA','333'),(6,'ŞERAFETTİN BÖLGE OTOPARKI','KARATAY','https://www.google.com/maps/place/Otopark-%C5%9Ferafettin+Cd.+Giri%C5%9Fi/@37.8727022,32.4981935,18.75z/data=!4m9!1m2!2m1!1zxZ5FUkFGRVRUxLBOIA!3m5!1s0x14d0850f16314dc7:0xbd788266d5d5f47b!8m2!3d37.872911!4d32.4990872!15sCgzFnkVSQUZFVFTEsE6SAQtwYXJraW5nX2xvdA','31'),(7,'YAPICI OTOPARKI','MERKEZ','https://www.google.com/maps/place/Yap%C4%B1c%C4%B1+%C4%B0%C5%9F+Mer./@37.8696123,32.4880573,16z/data=!4m9!1m2!2m1!1sYAPICI!3m5!1s0x14d085a58bb32511:0x1373061d81835c9d!8m2!3d37.8763277!4d32.484193!15sCgZZQVBJQ0mSAQ1idXNpbmVzc19wYXJr','45'),(8,'NALÇACI OTOPARKI','SELÇUKLU','https://www.google.com/maps/search/NAL%C3%87ACI+OTOPARK/@37.8856599,32.4818108,16z','80'),(9,'OTOGAR OTOPARK','SELÇUKLU','https://www.google.com/maps/place/Konya+Otogar%C4%B1/@37.9438839,32.5091707,15.79z/data=!4m9!1m2!2m1!1sKONYA+OTOGAR!3m5!1s0x14d08e415e944301:0x403263862ee4cf03!8m2!3d37.9502057!4d32.510006!15sCgxLT05ZQSBPVE9HQVKSAQtidXNfc3RhdGlvbg','236'),(10,'ALAEDDİN OTOPARKI','MERKEZ','https://www.google.com/maps/place/Alaaddin+Blv.,+Konya/@37.8732315,32.4892862,17.25z/data=!4m5!3m4!1s0x14d08507f67dec0b:0x4fa0bd060b47a6a4!8m2!3d37.8731128!4d32.4904076','24'),(11,'SELÇUK TIP OTOPARKI','SELÇUKLU','https://www.google.com/maps/place/Sel%C3%A7uk+%C3%9Cniversitesi+T%C4%B1p+Fak%C3%BCltesi+Hastanesi/@38.0230633,32.5129126,16.5z/data=!4m5!3m4!1s0x14d08d13004bcbc1:0x9574ca07df63df3f!8m2!3d38.020984!4d32.511739','500'),(12,'TOPTANCILAR','SELÇUKLU','https://www.google.com/maps/place/Feritpa%C5%9Fa,+G%C3%BClda%C4%9F+Sk.+No:3,+42060+Sel%C3%A7uklu%2FKonya/@37.8919951,32.4958467,17.25z/data=!4m8!1m2!2m1!1sTOPTANCILAR!3m4!1s0x14d08579dd99286b:0x9dee7cb86483a782!8m2!3d37.8916651!4d32.4961869','60'),(13,'MİMAR MUZAFFER AÇIK OTOPARKI','MERKEZ','https://www.google.com/maps/place/Mimar+Muzaffer+Cd.,+Meram%2FKonya/@37.8704116,32.490156,17z/data=!3m1!4b1!4m5!3m4!1s0x14d085a9d57bbd5d:0x631a9dfd25045582!8m2!3d37.8704074!4d32.4923447','100'),(14,'OSMANLI BUĞDAY PAZARI OTOPARKI','KARATAY','https://www.google.com/maps/place/Osmanl%C4%B1+Bugday+Pazar%C4%B1+%C3%87ar%C5%9F%C4%B1s%C4%B1/@37.8683973,32.4971032,17z/data=!3m1!4b1!4m5!3m4!1s0x14d085b0dc133283:0x5896645207bbc400!8m2!3d37.8683985!4d32.4993017','570'),(15,'KÜLTÜRPARK','MERKEZ','https://www.google.com/maps/search/K%C3%9CLT%C3%9CRPARK/@37.8742687,32.4886401,17.75z','100');
/*!40000 ALTER TABLE `otoparklar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yerbilgisi`
--

DROP TABLE IF EXISTS `yerbilgisi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yerbilgisi` (
  `yer_id` int NOT NULL AUTO_INCREMENT,
  `bossayisi` int NOT NULL,
  `dolusayisi` int NOT NULL,
  `otoparklar_otopark_id` int NOT NULL,
  PRIMARY KEY (`yer_id`,`otoparklar_otopark_id`),
  KEY `fk_yerbilgisi_otoparklar_idx` (`otoparklar_otopark_id`),
  CONSTRAINT `fk_yerbilgisi_otoparklar` FOREIGN KEY (`otoparklar_otopark_id`) REFERENCES `otoparklar` (`otopark_id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yerbilgisi`
--

LOCK TABLES `yerbilgisi` WRITE;
/*!40000 ALTER TABLE `yerbilgisi` DISABLE KEYS */;
INSERT INTO `yerbilgisi` VALUES (1,300,0,1),(2,637,-1,2),(3,296,1,3),(4,248,2,4),(5,332,1,5),(6,31,0,6),(7,45,0,7),(8,50,0,8),(9,236,0,9),(10,24,0,10),(11,120,0,11),(12,60,0,12),(13,100,0,13),(14,570,0,14),(15,100,0,15);
/*!40000 ALTER TABLE `yerbilgisi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-29  6:31:41
