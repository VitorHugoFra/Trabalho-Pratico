CREATE TABLE Sex (
    SexId INT AUTO_INCREMENT PRIMARY KEY,
    Sex VARCHAR(10) NOT NULL
);

CREATE TABLE JobTitle (
    JobTitleId INT AUTO_INCREMENT PRIMARY KEY,
    JobTitle VARCHAR(100) NOT NULL
);

CREATE TABLE Users (
    Indice INT AUTO_INCREMENT PRIMARY KEY,
	UserId INT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Sex INT,
    Email VARCHAR(255),
    Phone VARCHAR(20),
    Datebirth DATE,
    JobTitle INT,
    FOREIGN KEY (Sex) REFERENCES Sex(SexId),
    FOREIGN KEY (JobTitle) REFERENCES JobTitle(JobTitleId)
);


-- Inserção na tabela Sex
INSERT INTO Sex (Sex) VALUES ('Male');
INSERT INTO Sex (Sex) VALUES ('Female');

-- Inserção na tabela JobTitle
INSERT INTO JobTitle (JobTitle) VALUES ('Games developer');
INSERT INTO JobTitle (JobTitle) VALUES ('Phytotherapist');
INSERT INTO JobTitle (JobTitle) VALUES ('Homeopath');
INSERT INTO JobTitle (JobTitle) VALUES ('Market researcher');
INSERT INTO JobTitle (JobTitle) VALUES ('Veterinary surgeon');

ALTER TABLE Users MODIFY UserId VARCHAR(255);

-- Inserção na tabela Users
INSERT INTO Users (UserId, FirstName, LastName, Sex, Email, Phone, Datebirth, JobTitle) VALUES
('88F7B33d2bcf9f5', 'Shelby', 'Terrell', (SELECT SexId FROM Sex WHERE Sex='Male'), 'elijah57@example.net', '31994919928', '1945-10-26', (SELECT JobTitleId FROM JobTitle WHERE JobTitle='Games developer')),
('f90cD3E76f1A9b9', 'Phillip', 'Summers', (SELECT SexId FROM Sex WHERE Sex='Female'), 'bethany14@example.com', '31994919928', '1910-03-24', (SELECT JobTitleId FROM JobTitle WHERE JobTitle='Phytotherapist')),
('DbeAb8CcdfeFC2c', 'Kristine', 'Travis', (SELECT SexId FROM Sex WHERE Sex='Male'), 'bthompson@example.com', '31994919928', '1992-07-02', (SELECT JobTitleId FROM JobTitle WHERE JobTitle='Homeopath')),
('A31Bee3c201ef58', 'Yesenia', 'Martinez', (SELECT SexId FROM Sex WHERE Sex='Male'), 'kaitlinkaiser@example.com', '31994919928', '2017-08-03', (SELECT JobTitleId FROM JobTitle WHERE JobTitle='Market researcher')),
('1bA7A3dc874da3c', 'Lori', 'Todd', (SELECT SexId FROM Sex WHERE Sex='Male'), 'buchananmanuel@example.net', '31994919928', '1938-12-01', (SELECT JobTitleId FROM JobTitle WHERE JobTitle='Veterinary surgeon'));