CREATE TABLE IF NOT EXISTS languages
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

CREATE TABLE IF NOT EXISTS country_languages
(
    id INT GENERATED ALWAYS AS IDENTITY,
    country_id INT NOT NULL,
    language_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_country FOREIGN KEY(country_id) REFERENCES country(id),
    CONSTRAINT fk_language FOREIGN KEY(language_id) REFERENCES languages(id)
);

CREATE TABLE IF NOT EXISTS genres
(
    id INT GENERATED ALWAYS AS IDENTITY,
    name VARCHAR(255) UNIQUE NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS writer_genres
(
    id INT GENERATED ALWAYS AS IDENTITY,
    writer_id INT NOT NULL,
    genres_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_writer FOREIGN KEY(writer_id) REFERENCES writer(id),
    CONSTRAINT fk_genres FOREIGN KEY(genres_id) REFERENCES genres(id)
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
    release_date DATE NOT NULL,
    country_id INT NOT NULL,
    language_id INT NOT NULL,
    writer_id INT NOT NULL,
    genres_id INT NOT NULL,
    PRIMARY KEY(id),
    CONSTRAINT fk_country FOREIGN KEY(country_id) REFERENCES country(id),
    CONSTRAINT fk_language FOREIGN KEY(language_id) REFERENCES languages(id),
    CONSTRAINT fk_genres FOREIGN KEY(genres_id) REFERENCES genres(id),
    CONSTRAINT fk_writer FOREIGN KEY(writer_id) REFERENCES writer(id),
    CONSTRAINT uniq_writer_book UNIQUE (name, writer_id);
);