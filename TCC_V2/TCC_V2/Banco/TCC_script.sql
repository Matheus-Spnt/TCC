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
  `id_partido` INT NOT NULL,
  `id_eleicao` INT NOT NULL,
  PRIMARY KEY (`id_candidato`),
  INDEX `fk_candidato_partido1_idx` (`id_partido` ASC),
  INDEX `fk_candidato_eleicao1_idx` (`id_eleicao` ASC),
  CONSTRAINT `fk_candidato_partido1`
    FOREIGN KEY (`id_partido`)
    REFERENCES `tcc`.`partido` (`id_partido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_candidato_eleicao1`
    FOREIGN KEY (`id_eleicao`)
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
  `id_eleitor` INT NOT NULL,
  `id_eleicao` INT NOT NULL,
  `confirma_votar` TINYINT NULL DEFAULT 0,
  INDEX `fk_confirma_voto_eleitor1_idx` (`id_eleitor` ASC),
  INDEX `fk_confirma_voto_eleicao1_idx` (`id_eleicao` ASC),
  CONSTRAINT `fk_confirma_voto_eleitor1`
    FOREIGN KEY (`id_eleitor`)
    REFERENCES `tcc`.`eleitor` (`id_eleitor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_confirma_voto_eleicao1`
    FOREIGN KEY (`id_eleicao`)
    REFERENCES `tcc`.`eleicao` (`id_eleicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


-- Dados de teste para a tabela eleitor
INSERT INTO eleitor (nome_eleitor, data_nascimento, cpf, endereco, titulo_eleitor, zona_eleitoral, secao_eleitoral, senha) 
VALUES 
('João Silva', '1990-05-15', '12345678901', 'Rua A, 123', '123456789012', 1, 1, 'senha123'),
('Maria Oliveira', '1985-02-20', '23456789012', 'Rua B, 456', '234567890123', 2, 2, 'senha456');
-- Adicione mais eleitores conforme necessário

-- Dados de teste para a tabela partido
INSERT INTO partido (nome, sigla) 
VALUES 
('Partido A', 'PA'),
('Partido B', 'PB');
-- Adicione mais partidos conforme necessário

-- Dados de teste adicionais para a tabela partido
INSERT INTO partido (nome, sigla) 
VALUES 
('Partido C', 'PC'),
('Partido D', 'PD');
-- Adicione mais partidos conforme necessário

-- Dados de teste para a tabela eleicao
INSERT INTO eleicao (titulo, data_inicio, data_termino, local, descricao_eleicao) 
VALUES 
('Eleição Municipal 2023', '2023-11-01', '2023-11-15', 'Local A', 'Eleição para prefeito e vereadores'),
('Eleição Estadual 2023', '2023-12-01', '2023-12-15', 'Local B', 'Eleição para governador e deputados estaduais');
-- Adicione mais eleições conforme necessário

-- Dados de teste adicionais para a tabela eleicao
INSERT INTO eleicao (titulo, data_inicio, data_termino, local, descricao_eleicao) 
VALUES 
('Eleição Federal 2023', '2023-11-20', '2023-12-05', 'Local C', 'Eleição para presidente e congressistas federais'),
('Eleição Municipal 2024', '2024-01-10', '2024-01-25', 'Local D', 'Eleição para prefeito e vereadores');

INSERT INTO eleicao (titulo, data_inicio, local, descricao_eleicao) 
VALUES 
('Eleição Federal - Senado 2023', '2023-11-20', 'Local C', 'Eleição para presidente e congressistas federais'),
('Eleição Federal - Governador 2023', '2023-01-10', 'Local D', 'Eleição para prefeito e vereadores');


-- Adicione mais eleições conforme necessário

-- Dados de teste para a tabela candidato
INSERT INTO candidato (nome_candidato, numero_urna, id_partido, id_eleicao) 
VALUES 
('Candidato 1A', '11111', 1, 1),
('Candidato 2A', '22222', 1, 1);
-- Adicione mais candidatos conforme necessário

-- Dados de teste para a tabela voto
INSERT INTO voto (data_voto, partido_id_partido, candidato_id_candidato, eleitor_id_eleitor) 
VALUES 
('2023-11-02', 1, 1, 1),
('2023-11-03', 1, 2, 2);
-- Adicione mais votos conforme necessário

-- Dados de teste para a tabela confirma_voto
INSERT INTO confirma_voto (id_eleitor, id_eleicao, confirma_votar) 
VALUES 
(1, 1, 1),
(2, 1, 1),
(1, 3, 1),
(2, 3, 1),
(1, 4, 1),
(2, 4, 1),
(1, 2, 0),
(2, 2, 0);
-- Adicione mais confirmações de voto conforme necessário

-- Dados de teste adicionais para a tabela candidato
INSERT INTO candidato (nome_candidato, numero_urna, id_partido, id_eleicao) 
VALUES 
('Candidato 3A', '33333', 1, 1),
('Candidato 4A', '44444', 1, 1),
('Candidato 5B', '55555', 2, 2),
('Candidato 6B', '66666', 2, 2),
('Candidato 7B', '77777', 2, 2),
('Candidato 8B', '88888', 2, 2),
('Candidato 9C', '99999', 3, 3),
('Candidato 10C', '10101', 3, 3),
('Candidato 11C', '11111', 3, 3),
('Candidato 12C', '12121', 3, 3),
('Candidato 13D', '13131', 4, 4),
('Candidato 14D', '14141', 4, 4),
('Candidato 15D', '15151', 4, 4),
('Candidato 16D', '16161', 4, 4);
-- Adicione mais candidatos conforme necessário

/*select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votar from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor = 1 and cv.confirma_votar = 0 ;*/

select e.descricao_eleicao, e.id_eleicao, e.titulo, et.id_eleitor, cv.confirma_votar from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor = 1 and cv.confirma_votar = 1 and e.data_termino is null ;

select e.descricao_eleicao, e.id_eleicao, e.titulo from eleicao e join confirma_voto cv on(e.id_eleicao = cv.id_eleicao) join eleitor et on(cv.id_eleitor = et.id_eleitor) where et.id_eleitor = 1 and cv.confirma_votar = 1 and e.data_termino is null ;








