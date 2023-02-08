/*
 Navicat Premium Data Transfer

 Source Server         : Naumov
 Source Server Type    : MySQL
 Source Server Version : 80032
 Source Host           : localhost:3306
 Source Schema         : николаев

 Target Server Type    : MySQL
 Target Server Version : 80032
 File Encoding         : 65001

 Date: 08/02/2023 23:59:46
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for clientskaya baza fizicheskih lic
-- ----------------------------
DROP TABLE IF EXISTS `clientskaya baza fizicheskih lic`;
CREATE TABLE `clientskaya baza fizicheskih lic`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `pasport dannue` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mesto propiski` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `mesto rabotu` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `doljnost` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `bank tranzakcii` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `dannue o supruge` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `vozrast` int(0) NULL DEFAULT NULL,
  `pol` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of clientskaya baza fizicheskih lic
-- ----------------------------
INSERT INTO `clientskaya baza fizicheskih lic` VALUES (1, 'Ознобихин Григорий Андреевич', '+79086016545', 'Нижегородская область г.Бор, ул.Первомайская, дом 4, квартира 21', '22 22 555000', 'Нижегородская область г.Бор, ул.Первомайская, дом 4, квартира 21', 'ПАО Сбербанк', NULL, NULL, NULL, NULL, NULL);
INSERT INTO `clientskaya baza fizicheskih lic` VALUES (2, 'Борисов Андрей Андреевич', '+79045352100', 'г.Нижний Новгород, ул.Достоевская, дом 3, квартира 10', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- ----------------------------
-- Table structure for clientskaya baza kommercheskih lic
-- ----------------------------
DROP TABLE IF EXISTS `clientskaya baza kommercheskih lic`;
CREATE TABLE `clientskaya baza kommercheskih lic`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Companiya` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of clientskaya baza kommercheskih lic
-- ----------------------------
INSERT INTO `clientskaya baza kommercheskih lic` VALUES (1, 'Николаев Вадим Владимирович', '+79080010203', 'Нижегородская область г.Бор, ул. Луначарская, дом 1', 'Стёкла Бор');
INSERT INTO `clientskaya baza kommercheskih lic` VALUES (2, 'Какой-то чел Кирилл Романович', '+79035015161', 'Нижегородская область г.Бор, ул. Стеклозаводское шоссе, дом 3', 'Силикатный завод');
INSERT INTO `clientskaya baza kommercheskih lic` VALUES (3, 'fgdgdfg', '2', '1', '1');
INSERT INTO `clientskaya baza kommercheskih lic` VALUES (8, '1', '1', '1', '1');

-- ----------------------------
-- Table structure for novoe jilie
-- ----------------------------
DROP TABLE IF EXISTS `novoe jilie`;
CREATE TABLE `novoe jilie`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `etaj` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `kvartira` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `podjezd` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `comnat` int(0) NULL DEFAULT NULL,
  `sostoyanie` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `otdelka` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `price` decimal(10, 0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of novoe jilie
-- ----------------------------
INSERT INTO `novoe jilie` VALUES (1, 'г.Нижний Новгород, ул. Добролюбова, дом 1', '3', '31', '1', 2, 'продаётся', 'да', 6000000);
INSERT INTO `novoe jilie` VALUES (2, 'г.Нижний Новгород, ул.Горловская, дом 5', '4', '42', '2', 1, 'не продаётся', 'нет', 4000000);

-- ----------------------------
-- Table structure for objectu
-- ----------------------------
DROP TABLE IF EXISTS `objectu`;
CREATE TABLE `objectu`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `gorod` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `ylica` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `dom` int(0) NULL DEFAULT NULL,
  `etajeu` int(0) NULL DEFAULT NULL,
  `kvartir` int(0) NULL DEFAULT NULL,
  `podiezdov` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of objectu
-- ----------------------------
INSERT INTO `objectu` VALUES (1, 'г.Нижний Новгород', 'Добролюбова', 1, 5, 90, 3);
INSERT INTO `objectu` VALUES (2, 'г.Нижний Новгород', 'Горловская', 5, 9, 144, 4);
INSERT INTO `objectu` VALUES (3, '1', '1', 1, 1, 1, 1);
INSERT INTO `objectu` VALUES (4, '2', '2', 2, 2, 2, 2);
INSERT INTO `objectu` VALUES (5, '2', '2', 2, 2, 2, 2);
INSERT INTO `objectu` VALUES (6, '2', '2', 2, 2, 2, 2);
INSERT INTO `objectu` VALUES (7, '3', '3', 3, 3, 3, 3);
INSERT INTO `objectu` VALUES (8, '4', '4', 4, 4, 4, 4);
INSERT INTO `objectu` VALUES (9, '4', '4', 4, 4, 4, 4);
INSERT INTO `objectu` VALUES (10, '4', '4', 4, 4, 4, 4);
INSERT INTO `objectu` VALUES (11, '5', '5', 5, 5, 5, 5);
INSERT INTO `objectu` VALUES (12, '6', '6', 6, 6, 6, 6);
INSERT INTO `objectu` VALUES (13, '7', '7', 7, 7, 7, 7);
INSERT INTO `objectu` VALUES (14, '8', '8', 8, 8, 8, 8);
INSERT INTO `objectu` VALUES (15, '9', '9', 9, 9, 9, 9);
INSERT INTO `objectu` VALUES (16, '10', '10', 10, 10, 10, 10);
INSERT INTO `objectu` VALUES (17, '11', '11', 11, 11, 11, 11);
INSERT INTO `objectu` VALUES (18, '11', '11', 11, 11, 11, 11);
INSERT INTO `objectu` VALUES (19, '1', '1', 1, 1, 1, 1);
INSERT INTO `objectu` VALUES (20, '2', '2', 2, 2, 2, 2);

-- ----------------------------
-- Table structure for otdel kommercheskou nedvijimosti
-- ----------------------------
DROP TABLE IF EXISTS `otdel kommercheskou nedvijimosti`;
CREATE TABLE `otdel kommercheskou nedvijimosti`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `polnomochiya` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of otdel kommercheskou nedvijimosti
-- ----------------------------
INSERT INTO `otdel kommercheskou nedvijimosti` VALUES (1, 'Похомов Степан Юрьевич', '+79045672134', 'г.Нижний Новгород, ул. Комсомольская, дом 5', 'Главный менеджер');
INSERT INTO `otdel kommercheskou nedvijimosti` VALUES (2, 'Натолока Григорий Романович', '+79053215483', 'г.Нижний Новгород, ул. Первомайская, дом 2', 'Секретарь');
INSERT INTO `otdel kommercheskou nedvijimosti` VALUES (3, '1', '1', '1', '1');

-- ----------------------------
-- Table structure for otdel prodaji jiluh pomesheniu
-- ----------------------------
DROP TABLE IF EXISTS `otdel prodaji jiluh pomesheniu`;
CREATE TABLE `otdel prodaji jiluh pomesheniu`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `polnomochiya` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of otdel prodaji jiluh pomesheniu
-- ----------------------------
INSERT INTO `otdel prodaji jiluh pomesheniu` VALUES (1, 'Евгутин Пётр Сергеевич', '+79032673579', 'г.Нижний Новгород, ул. Пушкина, дом 4', 'Главный менеджер');
INSERT INTO `otdel prodaji jiluh pomesheniu` VALUES (2, 'Новиков Евгений Витальевич', '+79026052165', 'г.Нижний Новгород, ул. Победы, дом 2', 'Юрист');

-- ----------------------------
-- Table structure for otdel zemeljnuh otnosheniu
-- ----------------------------
DROP TABLE IF EXISTS `otdel zemeljnuh otnosheniu`;
CREATE TABLE `otdel zemeljnuh otnosheniu`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `adres` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `polnomochiya` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of otdel zemeljnuh otnosheniu
-- ----------------------------
INSERT INTO `otdel zemeljnuh otnosheniu` VALUES (1, 'Федоренко Михаил Сергеевич', '+79505674354', 'г.Нижний Новгород, ул. Свердловская, дом 3', 'Главный менеджер');
INSERT INTO `otdel zemeljnuh otnosheniu` VALUES (2, 'Филипов Андрей Владимирович', '+79083457841', 'г.Нижний Новгород, ул. Гастело, дом 1', 'Помощник менеджера');

-- ----------------------------
-- Table structure for sdelka
-- ----------------------------
DROP TABLE IF EXISTS `sdelka`;
CREATE TABLE `sdelka`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `id_clienta` int(0) NULL DEFAULT NULL,
  `id_kvartiru` int(0) NULL DEFAULT NULL,
  `id_menedjer` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `id_clienta`(`id_clienta`) USING BTREE,
  INDEX `id_menedjer`(`id_menedjer`) USING BTREE,
  INDEX `id_kvartiru`(`id_kvartiru`) USING BTREE,
  CONSTRAINT `sdelka_ibfk_1` FOREIGN KEY (`id_menedjer`) REFERENCES `otdel prodaji jiluh pomesheniu` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelka_ibfk_2` FOREIGN KEY (`id_kvartiru`) REFERENCES `novoe jilie` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelka_ibfk_3` FOREIGN KEY (`id_clienta`) REFERENCES `clientskaya baza kommercheskih lic` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sdelka
-- ----------------------------
INSERT INTO `sdelka` VALUES (1, 1, 1, 1);
INSERT INTO `sdelka` VALUES (2, 2, 2, 2);

-- ----------------------------
-- Table structure for sdelki fizicheskih lic
-- ----------------------------
DROP TABLE IF EXISTS `sdelki fizicheskih lic`;
CREATE TABLE `sdelki fizicheskih lic`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `id_clienta` int(0) NULL DEFAULT NULL,
  `id_objecta` int(0) NULL DEFAULT NULL,
  `id_menedjera` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `id_clienta`(`id_clienta`) USING BTREE,
  INDEX `id_menedjera`(`id_menedjera`) USING BTREE,
  INDEX `id_objecta`(`id_objecta`) USING BTREE,
  CONSTRAINT `sdelki fizicheskih lic_ibfk_1` FOREIGN KEY (`id_clienta`) REFERENCES `clientskaya baza fizicheskih lic` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelki fizicheskih lic_ibfk_2` FOREIGN KEY (`id_objecta`) REFERENCES `objectu` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelki fizicheskih lic_ibfk_3` FOREIGN KEY (`id_menedjera`) REFERENCES `otdel zemeljnuh otnosheniu` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sdelki fizicheskih lic
-- ----------------------------
INSERT INTO `sdelki fizicheskih lic` VALUES (1, 1, 1, 1);
INSERT INTO `sdelki fizicheskih lic` VALUES (2, 2, 2, 2);

-- ----------------------------
-- Table structure for sdelki uridicheskih lic
-- ----------------------------
DROP TABLE IF EXISTS `sdelki uridicheskih lic`;
CREATE TABLE `sdelki uridicheskih lic`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `id_clienta` int(0) NULL DEFAULT NULL,
  `id_objecta` int(0) NULL DEFAULT NULL,
  `id_menedjera` int(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `id_menedjera`(`id_menedjera`) USING BTREE,
  INDEX `id_clienta`(`id_clienta`) USING BTREE,
  INDEX `id_objecta`(`id_objecta`) USING BTREE,
  CONSTRAINT `sdelki uridicheskih lic_ibfk_1` FOREIGN KEY (`id_objecta`) REFERENCES `objectu` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelki uridicheskih lic_ibfk_2` FOREIGN KEY (`id_menedjera`) REFERENCES `otdel kommercheskou nedvijimosti` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `sdelki uridicheskih lic_ibfk_3` FOREIGN KEY (`id_clienta`) REFERENCES `clientskaya baza kommercheskih lic` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sdelki uridicheskih lic
-- ----------------------------
INSERT INTO `sdelki uridicheskih lic` VALUES (1, 1, 1, 2);
INSERT INTO `sdelki uridicheskih lic` VALUES (2, 2, 2, 2);
INSERT INTO `sdelki uridicheskih lic` VALUES (3, 3, 3, 3);
INSERT INTO `sdelki uridicheskih lic` VALUES (4, 3, 3, 3);
INSERT INTO `sdelki uridicheskih lic` VALUES (5, NULL, 6, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (6, NULL, 7, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (7, NULL, 9, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (8, NULL, 11, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (9, NULL, 12, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (10, NULL, 13, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (11, NULL, 14, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (12, NULL, 15, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (13, NULL, 16, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (14, NULL, 17, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (15, NULL, 19, NULL);
INSERT INTO `sdelki uridicheskih lic` VALUES (16, NULL, 20, NULL);

-- ----------------------------
-- Table structure for sotrudniki
-- ----------------------------
DROP TABLE IF EXISTS `sotrudniki`;
CREATE TABLE `sotrudniki`  (
  `Id` int(0) NULL DEFAULT NULL,
  `FIO` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Login` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Dostyp` int(0) NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of sotrudniki
-- ----------------------------
INSERT INTO `sotrudniki` VALUES (0, 'Root', 'root', 'toor', 2);
INSERT INTO `sotrudniki` VALUES (1, 'Похомов Степан Юрьевич', 'uc1', 'ps1', 1);
INSERT INTO `sotrudniki` VALUES (2, 'Натолока Григорий Романович', 'uc2', 'ps2', 1);

SET FOREIGN_KEY_CHECKS = 1;
