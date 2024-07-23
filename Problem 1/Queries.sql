CREATE TABLE StatusTable(
	StatusID INT NOT NULL AUTO_INCREMENT,
    StatusCode VARCHAR(50),
    PRIMARY KEY (StatusID)
);


CREATE TABLE Students(
	StudentID INT NOT NULL AUTO_INCREMENT,
    Firstname VARCHAR(50),
    Lastname VARCHAR(50),
    Address VARCHAR(255),
    Age INT,
    Gender CHAR,
    StatusID INT,
    
    FOREIGN KEY(StatusID)
		REFERENCES StatusTable (StatusID),
	PRIMARY KEY (StudentID)
    );
