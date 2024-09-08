CREATE DATABASE UserLoginDB;
USE UserLoginDB;

CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL, -- Store hashed password
    CreatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE UserPreferences (
    PreferenceID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    LanguagePreference VARCHAR(50) DEFAULT 'English',
    ThemePreference VARCHAR(50) DEFAULT 'Light',
    NotificationsEnabled BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

INSERT INTO Users (Username, Email, PasswordHash)
VALUES ('john_doe', 'john.doe@example.com', SHA2('YourPassword123', 256)); -- Using SHA2 to hash the password

INSERT INTO UserPreferences (UserID, LanguagePreference, ThemePreference, NotificationsEnabled)
VALUES (1, 'English', 'Dark', TRUE);

CREATE USER 'dbuser'@'localhost' IDENTIFIED BY 'YourSecurePassword';
GRANT ALL PRIVILEGES ON UserLoginDB.* TO 'dbuser'@'localhost';

SHOW VARIABLES LIKE 'have_ssl';

ALTER USER 'dbuser'@'localhost' REQUIRE SSL;

FLUSH PRIVILEGES;

SHOW VARIABLES LIKE 'have_ssl';
SHOW STATUS LIKE 'Ssl_cipher';







