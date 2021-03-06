/*
Navicat MySQL Data Transfer

Source Server         : mysql57
Source Server Version : 50717
Source Host           : localhost:3306
Source Database       : hospital

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2017-06-29 10:42:42
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `picture`
-- ----------------------------
DROP TABLE IF EXISTS `picture`;
CREATE TABLE `picture` (
`ID`  int(11) NOT NULL AUTO_INCREMENT ,
`pname`  varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`stype`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`sdate`  date NULL DEFAULT NULL ,
`content`  varchar(5500) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`title`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
PRIMARY KEY (`ID`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=19

;

-- ----------------------------
-- Records of picture
-- ----------------------------
BEGIN;
INSERT INTO `picture` VALUES ('1', '../images/4.jpg', '医师介绍', '2017-05-23', '主任医师 教授 博士研究生导师', '方圻 医师教授'), ('2', '../images/5.jpg', '医师介绍', '2017-05-23', '特长：内科及心内科复杂、危重病例的诊治。', '戴玉华 主任医师 教授'), ('3', '../images/6.jpg', '医师介绍', '2017-05-23', '特长：擅长心血管疾病的诊治，尤其在心血管血液动力学和高血压方面有深入的研究。', '纪宝华 主任医师 教授'), ('4', '../images/7.jpg', '医师介绍', '2017-05-23', '特长：心脏疾病的药物治疗。', '戴玉华 主任医师 教授'), ('5', '../images/1.gif', '就诊指南', '2017-05-23', null, null), ('6', '../images/2.gif', '就诊指南', '2017-05-23', null, null), ('7', '../images/3.gif', '就诊指南', '2017-05-23', '\r\n', ''), ('8', '../images/1.PNG', '特殊检查项目', '2017-02-08', null, null), ('9', '../images/2.PNG', '特殊检查项目', '2017-02-08', null, null), ('10', '../images/3.PNG', '特殊检查项目', '2017-02-08', null, null), ('11', '../images/4.PNG', '特殊检查项目', '2017-02-08', null, null), ('12', '../images/5.PNG', '特殊检查项目', '2017-02-08', null, null), ('13', '../images/6.PNG', '特殊检查项目', '2017-02-08', null, null), ('14', '../images/7.PNG', '特殊检查项目', '2017-02-08', null, null), ('15', '../images/8.PNG', '特殊检查项目', '2017-02-08', null, null), ('16', '../images/9.PNG', '特殊检查项目', '2017-02-08', null, null), ('17', '../images/pic1.gif', '尾部', '2017-02-08', null, null), ('18', '../images/10.PNG', '头部', '2017-02-08', null, null);
COMMIT;

-- ----------------------------
-- Table structure for `text`
-- ----------------------------
DROP TABLE IF EXISTS `text`;
CREATE TABLE `text` (
`ID`  int(11) NOT NULL AUTO_INCREMENT ,
`type`  varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`title`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`content`  varchar(5500) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`sdate`  date NULL DEFAULT NULL ,
PRIMARY KEY (`ID`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=34

;

-- ----------------------------
-- Records of text
-- ----------------------------
BEGIN;
INSERT INTO `text` VALUES ('1', '科室动态', '冠心病的病因和危险因素', '冠心病的病因和危险因素', '2017-06-28'), ('2', '科室动态', '冠心病的病因和危险因素', '冠心病的病因和危险因素', '2015-12-22'), ('3', '科室动态', '我在协和进修的日子...', '我在协和进修的日子', '2015-12-22'), ('4', '科室动态', '时光如流沙，打磨信仰....', '时光如流沙，打磨信念', '2014-11-18'), ('5', '科室动态', '2014年心脏教育周心房颤...', '2014年心脏教育周心房颤动义诊在我院举办', '2014-11-18'), ('6', '科室动态', '我院心内科狠抓科研基础，多领...', '我院心内科狠抓科研基础，多领...', '2014-11-18'), ('7', '科室动态', '北京协和医院国内首次确诊Danon.....', '北京协和医院国内首次确诊Danon病 专家提示：男童表现心肌肥厚时须提高警惕', '2014-11-18'), ('8', '科研教学', '协和心脏论坛', '协和心脏论坛', '2015-12-22'), ('9', '科研教学', '科研与教学', '科研与教学', '2015-12-22'), ('10', '科室简介', '', '协和医院心内科具有悠久的历史。早在中华人民共和国成立初期，由黄宛教授和方圻教授组建了协和医院内科心组，率先在国内开展了心血管专科的临床和研究工作。50年代初期，黄宛教授等从修复三导联的弦线心电图机开始到制造出十二导联心电图机，为心电图在我国的普及做出了巨大的贡献。50年代末期，在黄宛和方圻教授的领导下，心组在国内率先开展了右心导管和血液动力学监测。在1958年北京阜外医院成立初期，黄宛、方圻、陈在嘉、吴宁教授等由协和医院心组调往阜外医院，为我国第一家心血管专科医院的创立做出了贡献。此后，方圻和吴宁教授返回协和。方圻、金兰、吴宁和朱文玲教授曾先后担任心内科行政主任[详细内容]', '2017-06-28'), ('11', '健康教育', '房颤的药物治疗', '房颤的药物治疗', '2014-11-18'), ('12', '健康教育', '冠心病', '冠心病', '2014-11-18'), ('13', '健康教育', '冠心病的病因和危险因素', '冠心病的病因和危险因素', '2014-11-18'), ('14', '健康教育', '什么是冠心病二级预防？', '什么是冠心病二级预防？', '2014-11-18'), ('15', '健康教育', '冠心病介入放支架手术后有哪些....', '冠心病介入放支架手术后有哪些....', '2014-11-18'), ('16', '医师介绍', '纪宝华 主任医师 教授', '特长：擅长心血管疾病的诊治，尤其在心血管血液动力学和高血压方面有深入的研究。', '2015-12-22'), ('17', '医师介绍', '朱文玲 主任医师教授', '特长：内科及心内科复杂、危重病例的诊治。', '2015-12-22'), ('18', '医师介绍', '戴玉华 主任医师 教授', '特长：心脏疾病的药物治疗。', '2015-12-22'), ('19', '医师介绍', '方圻 医师教授', '主任医师 教授 博士研究生导师', '2015-12-22'), ('20', '特殊检查项目', '心脏起搏器', '心脏起搏器', '2015-12-22'), ('21', '特殊检查项目', '心脏彩超简介', '心脏彩超简介', '2015-12-22'), ('22', '特殊检查项目', '心电图平板运动试验', '心电图平板运动试验', '2015-12-22'), ('23', '特殊检查项目', '心电图', '心电图', '2015-12-22'), ('24', '特殊检查项目', '射频消融术', '射频消融术', '2015-12-22'), ('25', '特殊检查项目', '冠脉支架植入示意图', '冠脉支架植入示意图', '2015-12-22'), ('26', '特殊检查项目', '冠脉造影', '冠脉造影', '2015-12-22'), ('27', '特殊检查项目', '冠脉介入手术过程简图', '冠脉介入手术过程简图', '2015-12-22'), ('28', '特殊检查项目', '动态心电图', '动态心电图', '2015-12-22'), ('29', '尾部', '', '地址：（东院）北京市东城区帅府园一号，100730；（西院）北京市西城区大木仓胡同41号，100032', '2014-11-18'), ('30', '尾部', '', '医院电话：69156114', '2014-11-18'), ('31', '尾部', '', '文保网安备案号：1101010023 京卫网审字【2014】第39号', '2014-11-18'), ('32', '尾部', '', '网址：http://www.pumch.cn', '2014-11-18'), ('33', '尾部', '', '2014-2016 All Rights Reserved&copy; 北京协和医院', '2014-11-18');
COMMIT;

-- ----------------------------
-- Auto increment value for `picture`
-- ----------------------------
ALTER TABLE `picture` AUTO_INCREMENT=19;

-- ----------------------------
-- Auto increment value for `text`
-- ----------------------------
ALTER TABLE `text` AUTO_INCREMENT=34;
