CREATE TABLE IF NOT EXISTS language
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS country
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS country_language
(
    id INT GENERATED ALWAYS AS IDENTITY,
    country_id INT NOT NULL,
    language_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_country FOREIGN KEY(country_id) REFERENCES country(id),
    CONSTRAINT fk_language FOREIGN KEY(language_id) REFERENCES language(id)
);

CREATE TABLE IF NOT EXISTS genre
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS writer_genre
(
    id INT GENERATED ALWAYS AS IDENTITY,
    writer_id INT NOT NULL,
    genre_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_writer FOREIGN KEY(writer_id) REFERENCES writer(id),
    CONSTRAINT fk_genre FOREIGN KEY(genre_id) REFERENCES genre(id)
    );

CREATE TABLE IF NOT EXISTS writer
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) UNIQUE NOT NULL,
    country_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_country FOREIGN KEY(country_id) REFERENCES country(id)
);

CREATE TABLE IF NOT EXISTS book
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) NOT NULL,
    content VARCHAR(1024) NOT NULL,
    language_id INT NOT NULL,
    writer_id INT NOT NULL,
    genre_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_language FOREIGN KEY(language_id) REFERENCES language(id),
    CONSTRAINT fk_genre FOREIGN KEY(genre_id) REFERENCES genre(id),
    CONSTRAINT fk_writer FOREIGN KEY(writer_id) REFERENCES writer(id),
    CONSTRAINT uniq_writer_book UNIQUE (name, writer_id);
);