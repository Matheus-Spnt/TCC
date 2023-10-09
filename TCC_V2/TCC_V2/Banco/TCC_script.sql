-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema tcc
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `tcc` ;

-- -----------------------------------------------------
-- Schema tcc
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `tcc` DEFAULT CHARACTER SET utf8 ;
USE `tcc` ;

-- -----------------------------------------------------
-- Table `tcc`.`eleitor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`eleitor` (
  `id_eleitor` INT NOT NULL AUTO_INCREMENT,
  `nome_eleitor` VARCHAR(50) NULL,
  `data_nascimento` DATE NULL,
  `cpf` VARCHAR(11) NULL,
  `endereco` VARCHAR(100) NULL,
  `titulo_eleitor` VARCHAR(12) NULL,
  `zona_eleitoral` INT NULL,
  `secao_eleitoral` INT NULL,
  `senha` VARCHAR(45) NULL,
  PRIMARY KEY (`id_eleitor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tcc`.`partido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`partido` (
  `id_partido` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  `sigla` VARCHAR(10) NULL,
  PRIMARY KEY (`id_partido`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tcc`.`eleicao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`eleicao` (
  `id_eleicao` INT NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NULL,
  `data_inicio` DATE NULL,
  `data_termino` DATE NULL,
  `local` VARCHAR(45) NULL,
  `descricao_eleicao` VARCHAR(250) NULL,
  PRIMARY KEY (`id_eleicao`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tcc`.`candidato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`candidato` (
  `id_candidato` INT NOT NULL AUTO_INCREMENT,
  `nome_candidato` VARCHAR(50) NULL,
  `numero_urna` VARCHAR(5) NULL,
  `partido_id_partido` INT NOT NULL,
  `eleicao_id_eleicao` INT NOT NULL,
  PRIMARY KEY (`id_candidato`),
  INDEX `fk_candidato_partido1_idx` (`partido_id_partido` ASC),
  INDEX `fk_candidato_eleicao1_idx` (`eleicao_id_eleicao` ASC),
  CONSTRAINT `fk_candidato_partido1`
    FOREIGN KEY (`partido_id_partido`)
    REFERENCES `tcc`.`partido` (`id_partido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_candidato_eleicao1`
    FOREIGN KEY (`eleicao_id_eleicao`)
    REFERENCES `tcc`.`eleicao` (`id_eleicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tcc`.`voto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`voto` (
  `id_voto` INT NOT NULL AUTO_INCREMENT,
  `data_voto` DATE NULL,
  `partido_id_partido` INT NOT NULL,
  `candidato_id_candidato` INT NOT NULL,
  `eleitor_id_eleitor` INT NOT NULL,
  PRIMARY KEY (`id_voto`),
  INDEX `fk_voto_partido1_idx` (`partido_id_partido` ASC),
  INDEX `fk_voto_candidato1_idx` (`candidato_id_candidato` ASC),
  INDEX `fk_voto_eleitor1_idx` (`eleitor_id_eleitor` ASC),
  CONSTRAINT `fk_voto_partido1`
    FOREIGN KEY (`partido_id_partido`)
    REFERENCES `tcc`.`partido` (`id_partido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_voto_candidato1`
    FOREIGN KEY (`candidato_id_candidato`)
    REFERENCES `tcc`.`candidato` (`id_candidato`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_voto_eleitor1`
    FOREIGN KEY (`eleitor_id_eleitor`)
    REFERENCES `tcc`.`eleitor` (`id_eleitor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tcc`.`confirma_voto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `tcc`.`confirma_voto` (
  `eleitor_id_eleitor` INT NOT NULL,
  `eleicao_id_eleicao` INT NOT NULL,
  `confirma_votar` TINYINT NULL DEFAULT 0,
  INDEX `fk_confirma_voto_eleitor1_idx` (`eleitor_id_eleitor` ASC),
  INDEX `fk_confirma_voto_eleicao1_idx` (`eleicao_id_eleicao` ASC),
  CONSTRAINT `fk_confirma_voto_eleitor1`
    FOREIGN KEY (`eleitor_id_eleitor`)
    REFERENCES `tcc`.`eleitor` (`id_eleitor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_confirma_voto_eleicao1`
    FOREIGN KEY (`eleicao_id_eleicao`)
    REFERENCES `tcc`.`eleicao` (`id_eleicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
