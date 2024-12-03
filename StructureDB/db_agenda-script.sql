DROP DATABASE IF EXISTS db_agenda;
DROP USER IF EXISTS "admin"@"%";

CREATE DATABASE IF NOT EXISTS db_agenda;

USE db_agenda;

-- TABELA DE USUÁRIOS

CREATE TABLE IF NOT EXISTS tb_usuarios (
	pecado VARCHAR(20) NOT NULL,
	nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);

-- TABELA DE CATEGORIAS

CREATE TABLE IF NOT EXISTS tb_categorias (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    categoria VARCHAR(100) NOT NULL,

    CONSTRAINT fk_usuarios_categorias
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios(usuario)
    ON DELETE CASCADE
);


-- TABELA DE CONTATOS

CREATE TABLE IF NOT EXISTS tb_contatos (
    id_contato INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(15) NOT NULL,
    usuario VARCHAR(50),
    id_categoria INT,

    CONSTRAINT fk_usuarios_contatos
    FOREIGN KEY (usuario)
    REFERENCES tb_usuarios (usuario)
    ON DELETE CASCADE,
    
    CONSTRAINT fk_categorias_contatos
    FOREIGN KEY (id_categoria)
    REFERENCES tb_categorias (id_categoria)
    ON DELETE CASCADE
);

-- TABELA DE LOGS

CREATE TABLE IF NOT EXISTS tb_logs (
    id_log INT AUTO_INCREMENT PRIMARY KEY,
    usuario VARCHAR(50) NOT NULL,
    dt_alteracao DATETIME DEFAULT CURRENT_TIMESTAMP() NOT NULL,
    descricao VARCHAR(250) NOT NULL
);

-- USUÁRIO ADMIN

INSERT INTO tb_usuarios VALUES ("Ganância", "Belzebu", "admin", "(16) 66666-7777", "admin123");

CREATE USER 'admin'@'%' IDENTIFIED BY 'admin123';
GRANT ALL PRIVILEGES ON db_agenda.* TO 'admin'@'%' WITH GRANT OPTION;

-- TRIGGER SET PROPRIETARIO CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_insert_categoria
    BEFORE
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;

-- TRIGGER SET PROPRIETARIO CONTATO

DELIMITER $$

CREATE TRIGGER tr_insert_contato
    BEFORE
    INSERT
    ON tb_contatos
    FOR EACH ROW
BEGIN
    SET NEW.usuario = SUBSTRING_INDEX(USER(), '@', 1);
END;

$$

DELIMITER ;

-- TRIGGER LOG INSERT CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_insert_categoria
    AFTER
    INSERT
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CATEGORIA INSERIDA: ", NEW.categoria)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG DELETE CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_delete_categoria
    AFTER
    DELETE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CATEGORIA DELETADA: ", OLD.categoria, ". PROPRIETÁRIO: ", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG UPDATE CATEGORIA

DELIMITER $$

CREATE TRIGGER tr_log_update_categoria
    AFTER
    UPDATE
    ON tb_categorias
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("NOME DA CATEGORIA ALTERADO DE: ", OLD.categoria, " PARA: ", NEW.categoria, " PROPRIETÁRIO:", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG INSERT CONTATO

DELIMITER $$

CREATE TRIGGER tr_log_insert_contato
    AFTER
    INSERT
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("NOVO CONTATO INSERIDO: ", NEW.nome, " PROPRIETÁRIO: ", NEW.usuario)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG DELETE CONTATO

DELIMITER $$

CREATE TRIGGER tr_log_delete_contato
    AFTER
    DELETE
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CONTATO DELETADO: ", OLD.nome, " PROPRIETÁRIO: ", OLD.usuario)
    );
END;

$$

DELIMITER ;

-- TRIGGER LOG UPDATE CONTATO

DELIMITER $$

CREATE TRIGGER tr_log_update_contato
    AFTER
    UPDATE
    ON tb_contatos
    FOR EACH ROW
BEGIN
    INSERT INTO tb_logs (usuario, descricao) VALUES (
        USER(),
        CONCAT("CONTATO ALTERADO DE: ", OLD.nome, " PARA: ", NEW.nome, " PROPRIETÁRIO: ", OLD.usuario)
    );
END;

$$

DELIMITER ;