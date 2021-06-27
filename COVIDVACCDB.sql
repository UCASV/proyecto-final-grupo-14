CREATE DATABASE COVIDVACCDB;
USE COVIDVACCDB; 
SET LANGUAGE us_english;

CREATE TABLE CITIZEN (
dui VARCHAR(9) PRIMARY KEY,
first_name VARCHAR (50) NOT NULL,
last_name VARCHAR (50) NOT NULL,
birthday DATE NOT NULL,
email VARCHAR (50),
city_id INT NOT NULL,
institution_id INT NOT NULL,
);


CREATE TABLE CITIZEN_PHONE_NUMBER (
id INT PRIMARY KEY IDENTITY,
phone_number VARCHAR(8) NOT NULL,
citizen_id VARCHAR(9) NOT NULL
);

CREATE TABLE INSTITUTION (
id INT PRIMARY KEY,
institution_name VARCHAR (50)
);

CREATE TABLE AILMENTS (
id INT PRIMARY KEY IDENTITY,
illness_id INT NOT NULL,
citizen_id VARCHAR(9) NOT NULL
);

CREATE TABLE CHRONIC_ILLNESS (
id INT PRIMARY KEY,
illness VARCHAR (50)
);

CREATE TABLE EMPLOYEE (
id INT PRIMARY KEY IDENTITY,
first_name VARCHAR (50) NOT NULL,
last_name VARCHAR (50) NOT NULL,
institutional_mail VARCHAR (50) NOT NULL,
employee_type_id INT NOT NULL,
city_id INT NOT NULL
);

CREATE TABLE EMPLOYEE_TYPE(
id INT PRIMARY KEY,
employee_type VARCHAR (50)
);

CREATE TABLE LOGIN_INFO (
id INT PRIMARY KEY IDENTITY,
username VARCHAR (50) NOT NULL, 
userpassword VARCHAR (50) NOT NULL,
employee_id INT NOT NULL
);

CREATE TABLE LOGIN_RECORD(
id INT PRIMARY KEY IDENTITY,
employee_id INT NOT NULL,
cabin_id INT NOT NULL,
login_time DATETIME NOT NULL,
);

CREATE TABLE VACCINATION_APPOINTMENT(
id INT PRIMARY KEY IDENTITY,
app_date DATE NOT NULL,
app_time TIME NOT NULL,
cabin_id INT NOT NULL,
citizen_id VARCHAR(9) NOT NULL
);

CREATE TABLE VACCINATION_PROCESS(
id INT PRIMARY KEY IDENTITY,
process_date DATE NOT NULL,
process_time TIME NOT NULL,
vacc_time TIME NOT NULL,
vacc_app_id INT NOT NULL,
side_effects_id INT NOT NULL,
);

CREATE TABLE EMPLOYEEXPROCESS(
id INT PRIMARY KEY IDENTITY,
employee_id INT NOT NULL,
vacc_process_id INT NOT NULL
);

CREATE TABLE SYMPTOM(
id INT PRIMARY KEY,
symptom VARCHAR(30)
);

CREATE TABLE SIDE_EFFECTS(
id INT PRIMARY KEY IDENTITY,
symptom_id INT NOT NULL,
symptom_time TIME NOT NULL
);

CREATE TABLE CABIN(
id INT PRIMARY KEY IDENTITY,
email VARCHAR(50) NOT NULL,
city_id INT NOT NULL
);

CREATE TABLE CABIN_PHONE_NUMBER(
id INT PRIMARY KEY IDENTITY,
phone_number INT NOT NULL,
cabin_id INT NOT NULL
);

CREATE TABLE CITY(
id INT PRIMARY KEY IDENTITY,
city_name VARCHAR(50),
state_id INT NOT NULL
);

CREATE TABLE STATE(
id INT PRIMARY KEY,
state_name VARCHAR(50) NOT NULL
);


ALTER TABLE VACCINATION_APPOINTMENT ADD FOREIGN KEY (cabin_id) REFERENCES CABIN(id);
ALTER TABLE VACCINATION_APPOINTMENT ADD FOREIGN KEY (citizen_id) REFERENCES CITIZEN(dui);
ALTER TABLE SIDE_EFFECTS ADD FOREIGN KEY (symptom_id) REFERENCES SYMPTOM(id);
ALTER TABLE AILMENTS ADD FOREIGN KEY (citizen_id) REFERENCES CITIZEN(dui);
ALTER TABLE AILMENTS ADD FOREIGN KEY (illness_id) REFERENCES CHRONIC_ILLNESS (id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (city_id) REFERENCES CITY (id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (institution_id) REFERENCES INSTITUTION (id);
ALTER TABLE CITIZEN_PHONE_NUMBER ADD FOREIGN KEY(citizen_id) REFERENCES CITIZEN (dui);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (employee_type_id) REFERENCES EMPLOYEE_TYPE (id);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (city_id) REFERENCES CITY (id);
ALTER TABLE LOGIN_RECORD ADD FOREIGN KEY (employee_id) REFERENCES EMPLOYEE (id);
ALTER TABLE LOGIN_RECORD ADD FOREIGN KEY (cabin_id) REFERENCES CABIN (id);
ALTER TABLE CABIN_PHONE_NUMBER ADD FOREIGN KEY(cabin_id) REFERENCES CABIN (id);
ALTER TABLE CABIN ADD FOREIGN KEY(city_id) REFERENCES CITY (id);
ALTER TABLE CITY ADD FOREIGN KEY(state_id) REFERENCES STATE (id);
ALTER TABLE LOGIN_INFO ADD FOREIGN KEY (employee_id) REFERENCES EMPLOYEE (id);
ALTER TABLE EMPLOYEEXPROCESS ADD FOREIGN KEY (employee_id) REFERENCES EMPLOYEE (id);
ALTER TABLE EMPLOYEEXPROCESS ADD FOREIGN KEY (vacc_process_id) REFERENCES VACCINATION_PROCESS(id);
ALTER TABLE VACCINATION_PROCESS ADD FOREIGN KEY (side_effects_id) REFERENCES SIDE_EFFECTS(id);
ALTER TABLE VACCINATION_PROCESS ADD FOREIGN KEY (vacc_app_id) REFERENCES VACCINATION_APPOINTMENT(id);

INSERT INTO SYMPTOM VALUES (1, 'DOLOR EN AREA DE INYECCION');
INSERT INTO SYMPTOM VALUES (2, 'SENSIBILIDAD');
INSERT INTO SYMPTOM VALUES (3, 'ENROJECIMIENTO');
INSERT INTO SYMPTOM VALUES (4, 'FATIGA');
INSERT INTO SYMPTOM VALUES (5, 'DOLOR DE CABEZA');
INSERT INTO SYMPTOM VALUES (6, 'FIEBRE');
INSERT INTO SYMPTOM VALUES (7, 'MIALGIA');
INSERT INTO SYMPTOM VALUES (8, 'ARTRALGIA');
INSERT INTO SYMPTOM VALUES (9, 'ANAFILAXIA');

INSERT INTO INSTITUTION VALUES (1, 'EDUCACION');
INSERT INTO INSTITUTION VALUES (2, 'SALUD');
INSERT INTO INSTITUTION VALUES (3, 'SEGURIDAD');
INSERT INTO INSTITUTION VALUES (4, 'GOBERNACIÓN');
INSERT INTO INSTITUTION VALUES (5, 'MEDIOS DE COMUNICACIÓN');
INSERT INTO INSTITUTION VALUES (6, 'NO PERTENECE A NINGUNA');

INSERT INTO CHRONIC_ILLNESS VALUES (1, 'DIABETES');
INSERT INTO CHRONIC_ILLNESS VALUES (2, 'ENFERMEDAD PULMONAR OBSTRUCTIVA CRONICA');
INSERT INTO CHRONIC_ILLNESS VALUES (3, 'INSUFICIENCIA RENAL CRONICA');
INSERT INTO CHRONIC_ILLNESS VALUES (4, 'CANCER');
INSERT INTO CHRONIC_ILLNESS VALUES (5, 'TENSION ARTERIAL ALTA');
INSERT INTO CHRONIC_ILLNESS VALUES (6, 'ENFERMEDAD HEPATICA');
INSERT INTO CHRONIC_ILLNESS VALUES (7, 'TRASPLANTE DE ORGANO');
INSERT INTO CHRONIC_ILLNESS VALUES (9, 'PERSONA INMUNODEPRIMIDA');
INSERT INTO CHRONIC_ILLNESS VALUES (10, 'ENFERMEDAD CARDIOVASCULAR');
INSERT INTO CHRONIC_ILLNESS VALUES (11, 'OBESIDAD');
INSERT INTO CHRONIC_ILLNESS VALUES (12, 'TRASTORNO SANGUINEO');
INSERT INTO CHRONIC_ILLNESS VALUES (13, 'AFECCION NEUROLOGICA');
INSERT INTO CHRONIC_ILLNESS VALUES (14, 'SINDROME DOWN');
INSERT INTO CHRONIC_ILLNESS VALUES (15, 'VIH');

INSERT INTO EMPLOYEE_TYPE VALUES (1, 'GESTOR');
INSERT INTO EMPLOYEE_TYPE VALUES (2, 'ASISTENTE DE SALUD');
INSERT INTO EMPLOYEE_TYPE VALUES (3, 'VACUNADOR');


INSERT INTO STATE VALUES (1, 'SANTA ANA');
INSERT INTO STATE VALUES (2, 'SONSONATE');
INSERT INTO STATE VALUES (3, 'AHUACHAPAN');
INSERT INTO STATE VALUES (4, 'LA LIBERTAD');
INSERT INTO STATE VALUES (5, 'CHALATENANGO');
INSERT INTO STATE VALUES (6, 'SAN SALVADOR');
INSERT INTO STATE VALUES (7, 'CUSCATLAN');
INSERT INTO STATE VALUES (8, 'LA PAZ');
INSERT INTO STATE VALUES (9, 'CABAÑAS');
INSERT INTO STATE VALUES (10, 'SAN VICENTE');
INSERT INTO STATE VALUES (11, 'USULUTAN');
INSERT INTO STATE VALUES (12, 'SAN MIGUEL');
INSERT INTO STATE VALUES (13, 'MORAZAN');
INSERT INTO STATE VALUES (14, 'LA UNION');

/* MUNICIPIOS DE SANTA ANA */
INSERT INTO CITY VALUES ('CANDELARIA DE LA FRONTERA', 1);
INSERT INTO CITY VALUES ('CHALCHUAPA', 1);
INSERT INTO CITY VALUES ('COATEPEQUE', 1);
INSERT INTO CITY VALUES ('EL CONGO', 1);
INSERT INTO CITY VALUES ('EL PORVENIR', 1);
INSERT INTO CITY VALUES ('MASAHUAT', 1);
INSERT INTO CITY VALUES ('METAPAN', 1);
INSERT INTO CITY VALUES ('SAN ANTONIO PAJONAL', 1);
INSERT INTO CITY VALUES ('SAN SEBASTIAN SALITRILLO', 1);
INSERT INTO CITY VALUES ('SANTA ANA', 1);
INSERT INTO CITY VALUES ('SANTA ROSA GUACHIPILIN', 1);
INSERT INTO CITY VALUES ('SANTIAGO DE LA FRONTERA', 1);
INSERT INTO CITY VALUES ('TEXISTEPEQUE', 1);

/* MUNICIPIOS DE SONSONATE */
INSERT INTO CITY VALUES ('ACAJUTLA', 2);
INSERT INTO CITY VALUES ('ARMENIA', 2);
INSERT INTO CITY VALUES ('CALUCO', 2);
INSERT INTO CITY VALUES ('CUISNAHUAT', 2);
INSERT INTO CITY VALUES ('IZALCO', 2);
INSERT INTO CITY VALUES ('JUAYUA', 2);
INSERT INTO CITY VALUES ('NAHUIZALCO', 2);
INSERT INTO CITY VALUES ('NAHULINGO', 2);
INSERT INTO CITY VALUES ('SALCOATITAN', 2);
INSERT INTO CITY VALUES ('SAN ANTONIO DEL MONTE', 2);
INSERT INTO CITY VALUES ('SAN JULIAN', 2);
INSERT INTO CITY VALUES ('SANTA CATARINA MASAHUAT', 2);
INSERT INTO CITY VALUES ('SANTA ISABEL ISHUATAN', 2);
INSERT INTO CITY VALUES ('SONSONATE', 2);
INSERT INTO CITY VALUES ('SONZACATE', 2);

/* MUNICIPIOS DE AHUACHAPAN */
INSERT INTO CITY VALUES ('AHUACHAPAN', 3);
INSERT INTO CITY VALUES ('APANECA', 3);
INSERT INTO CITY VALUES ('ATIQUIZAYA', 3);
INSERT INTO CITY VALUES ('CONCEPCION DE ATACO', 3);
INSERT INTO CITY VALUES ('EL REFUGIO', 3);
INSERT INTO CITY VALUES ('GUAYMANGO', 3);
INSERT INTO CITY VALUES ('JUJUTLA', 3);
INSERT INTO CITY VALUES ('SAN FRANCISCO MENENDEZ', 3);
INSERT INTO CITY VALUES ('SAN LORENZO', 3);
INSERT INTO CITY VALUES ('SAN PEDRO PUXTLA', 3);
INSERT INTO CITY VALUES ('TACUBA', 3);
INSERT INTO CITY VALUES ('TURIN', 3);

/* MUNICIPIOS DE LA LIBERTAD */
INSERT INTO CITY VALUES ('ANTIGUO CUSCATLAN', 4);
INSERT INTO CITY VALUES ('CHILTIUPAN', 4);
INSERT INTO CITY VALUES ('CIUDAD ARCE', 4);
INSERT INTO CITY VALUES ('COLON', 4);
INSERT INTO CITY VALUES ('COMASAGUA', 4);
INSERT INTO CITY VALUES ('HUIZUCAR', 4);
INSERT INTO CITY VALUES ('JAYAQUE', 4);
INSERT INTO CITY VALUES ('JICALAPA', 4);
INSERT INTO CITY VALUES ('LA LIBERTAD', 4);
INSERT INTO CITY VALUES ('SANTA TECLA', 4);
INSERT INTO CITY VALUES ('NUEVO CUSCATLAN', 4);
INSERT INTO CITY VALUES ('SAN JUAN OPICO', 4);
INSERT INTO CITY VALUES ('QUEZALTEPEQUE', 4);
INSERT INTO CITY VALUES ('SACACOYO', 4);
INSERT INTO CITY VALUES ('SAN JOSE VILLANUEVA', 4);
INSERT INTO CITY VALUES ('SAN MATIAS', 4);
INSERT INTO CITY VALUES ('SAN PABLO TACACHICO', 4);
INSERT INTO CITY VALUES ('TALNIQUE', 4);
INSERT INTO CITY VALUES ('TAMANIQUE', 4);
INSERT INTO CITY VALUES ('TEOTEPEQUE', 4);
INSERT INTO CITY VALUES ('TEPECOYO', 4);
INSERT INTO CITY VALUES ('ZARAGOZA', 4);

/* MUNICIPIOS DE CHALATENANGO */
INSERT INTO CITY VALUES ('AGUA CALIENTE', 5);
INSERT INTO CITY VALUES ('ARCATAO', 5);
INSERT INTO CITY VALUES ('CHALATENANGO', 5);
INSERT INTO CITY VALUES ('COMALAPA', 5);
INSERT INTO CITY VALUES ('CITALA', 5);
INSERT INTO CITY VALUES ('CONCEPCION QUEZALTEPEQUE', 5);
INSERT INTO CITY VALUES ('DULCE NOMBRE DE MARIA', 5);
INSERT INTO CITY VALUES ('EL CARRIZAL', 5);
INSERT INTO CITY VALUES ('EL PARAISO', 5);
INSERT INTO CITY VALUES ('LA LAGUNA', 5);
INSERT INTO CITY VALUES ('LA PALMA', 5);
INSERT INTO CITY VALUES ('LA REINA', 5);
INSERT INTO CITY VALUES ('LAS VUELTAS', 5);
INSERT INTO CITY VALUES ('NUEVA CONCEPCION', 5);
INSERT INTO CITY VALUES ('NUEVA TRINIDAD', 5);
INSERT INTO CITY VALUES ('NOMBRE DE JESUS', 5);
INSERT INTO CITY VALUES ('OJOS DE AGUA', 5);
INSERT INTO CITY VALUES ('POTONICO', 5);
INSERT INTO CITY VALUES ('SAN ANTONIO DE LA CRUZ', 5);
INSERT INTO CITY VALUES ('SAN ANTONIO LOS RANCHOS', 5);
INSERT INTO CITY VALUES ('SAN FERNANDO', 5);
INSERT INTO CITY VALUES ('SAN FRANCISCO LEMPA', 5);
INSERT INTO CITY VALUES ('SAN FRANCISCO MORAZAN', 5);
INSERT INTO CITY VALUES ('SAN IGNACIO', 5);
INSERT INTO CITY VALUES ('SAN ISIDRO LABRADOR', 5);
INSERT INTO CITY VALUES ('SAN JOSE CANCASQUE', 5);
INSERT INTO CITY VALUES ('SAN JOSE LAS FLORES', 5);
INSERT INTO CITY VALUES ('SAN LUIS DEL CARMEN', 5);
INSERT INTO CITY VALUES ('SAN MIGUEL DE MERCEDES', 5);
INSERT INTO CITY VALUES ('SAN RAFAEL', 5);
INSERT INTO CITY VALUES ('SANTA RITA', 5);
INSERT INTO CITY VALUES ('TEJUTLA', 5);

/* MUNICIPIOS DE SAN SALVADOR*/
INSERT INTO CITY VALUES ('AGUILARES', 6);
INSERT INTO CITY VALUES ('APOPA', 6);
INSERT INTO CITY VALUES ('AYUTUXTEPEQUE', 6);
INSERT INTO CITY VALUES ('CUSCATANCINGO', 6);
INSERT INTO CITY VALUES ('CIUDAD DELGADO', 6);
INSERT INTO CITY VALUES ('EL PAISNAL', 6);
INSERT INTO CITY VALUES ('GUAZAPA', 6);
INSERT INTO CITY VALUES ('ILOPANGO', 6);
INSERT INTO CITY VALUES ('MEJICANOS', 6);
INSERT INTO CITY VALUES ('NEJAPA', 6);
INSERT INTO CITY VALUES ('PANCHIMALCO', 6);
INSERT INTO CITY VALUES ('ROSARIO DE MORA', 6);
INSERT INTO CITY VALUES ('SAN MARCOS', 6);
INSERT INTO CITY VALUES ('SAN MARTIN', 6);
INSERT INTO CITY VALUES ('SAN SALVADOR', 6);
INSERT INTO CITY VALUES ('SANTIAGO TEXACUANGOS', 6);
INSERT INTO CITY VALUES ('SANTO TOMAS', 6);
INSERT INTO CITY VALUES ('SOYAPANGO', 6);
INSERT INTO CITY VALUES ('TONACATEPEQUE', 6);

/* MUNICIPIOS DE CUSCATLAN */
INSERT INTO CITY VALUES ('CANDELARIA', 7);
INSERT INTO CITY VALUES ('COJUTEPEQUE', 7);
INSERT INTO CITY VALUES ('EL CARMEN', 7);
INSERT INTO CITY VALUES ('EL ROSARIO', 7);
INSERT INTO CITY VALUES ('MONTE SAN JUAN', 7);
INSERT INTO CITY VALUES ('ORATORIO DE CONCEPCION', 7);
INSERT INTO CITY VALUES ('SAN BARTOLOME PERULAPIA', 7);
INSERT INTO CITY VALUES ('SAN CRISTOBAL', 7);
INSERT INTO CITY VALUES ('SAN JOSE GUAYABAL', 7);
INSERT INTO CITY VALUES ('SAN PEDRO PERULAPAN', 7);
INSERT INTO CITY VALUES ('SAN RAFAEL CEDROS', 7);
INSERT INTO CITY VALUES ('SAN RAMON', 7);
INSERT INTO CITY VALUES ('SANTA CRUZ ANALQUITO', 7);
INSERT INTO CITY VALUES ('SANTA CRUZ MICHAPA', 7);
INSERT INTO CITY VALUES ('SUCHITOTO', 7);
INSERT INTO CITY VALUES ('TENANCINGO', 7);

/* MUNICIPIOS DE LA PAZ */
INSERT INTO CITY VALUES ('CUYULTITAN', 8);
INSERT INTO CITY VALUES ('EL ROSARIO', 8);
INSERT INTO CITY VALUES ('JERUSALEN', 8);
INSERT INTO CITY VALUES ('MERCEDES LA CEIBA', 8);
INSERT INTO CITY VALUES ('OLOCUILTA', 8);
INSERT INTO CITY VALUES ('PARAISO DE OSORIO', 8);
INSERT INTO CITY VALUES ('SAN ANTONIO MASAHUAT', 8);
INSERT INTO CITY VALUES ('SAN EMIGDIO', 8);
INSERT INTO CITY VALUES ('SAN FRANCISCO CHINAMECA', 8);
INSERT INTO CITY VALUES ('SAN JUAN NONUALCO', 8);
INSERT INTO CITY VALUES ('SAN JUAN TALPA', 8);
INSERT INTO CITY VALUES ('SAN JUAN TEPEZONTES', 8);
INSERT INTO CITY VALUES ('SAN LUIS TALPA', 8);
INSERT INTO CITY VALUES ('SAN LUIS LA HERRADURA', 8);
INSERT INTO CITY VALUES ('SAN MIGUEL TEPEZONTES', 8);
INSERT INTO CITY VALUES ('SAN PEDRO MASAHUAT', 8);
INSERT INTO CITY VALUES ('SAN PEDRO NONUALCO', 8);
INSERT INTO CITY VALUES ('SAN RAFAEL OBRAJUELO', 8);
INSERT INTO CITY VALUES ('SANTA MARIA OSTUMA', 8);
INSERT INTO CITY VALUES ('SANTIAGO NONUALCO', 8);
INSERT INTO CITY VALUES ('TAPALHUACA', 8);
INSERT INTO CITY VALUES ('ZACATECOLUCA', 8);

/* MUNICIPIOS DE CABAÑAS */
INSERT INTO CITY VALUES ('CINQUERA', 9);
INSERT INTO CITY VALUES ('DOLORES', 9);
INSERT INTO CITY VALUES ('GUACOTECTI', 9);
INSERT INTO CITY VALUES ('ILOBASCO', 9);
INSERT INTO CITY VALUES ('JUTIAPA', 9);
INSERT INTO CITY VALUES ('SAN ISIDRO', 9);
INSERT INTO CITY VALUES ('SENSUNTEPEQUE', 9);
INSERT INTO CITY VALUES ('TEJUTEPEQUE', 9);
INSERT INTO CITY VALUES ('VICTORIA', 9);

/* MUNICIPIOS DE SAN VICENTE */
INSERT INTO CITY VALUES ('APASTEPEQUE', 10);
INSERT INTO CITY VALUES ('GUADALUPE', 10);
INSERT INTO CITY VALUES ('SAN CAYETANO ISTEPEQUE', 10);
INSERT INTO CITY VALUES ('SAN ESTEBAN CATARINA', 10);
INSERT INTO CITY VALUES ('SAN ILDEFONSO', 10);
INSERT INTO CITY VALUES ('SAN LORENZO', 10);
INSERT INTO CITY VALUES ('SAN SEBASTIAN', 10);
INSERT INTO CITY VALUES ('SAN VICENTE', 10);
INSERT INTO CITY VALUES ('SANTA CLARA', 10);
INSERT INTO CITY VALUES ('SANTO DOMINGO', 10);
INSERT INTO CITY VALUES ('TECOLUCA', 10);
INSERT INTO CITY VALUES ('TEPETITAN', 10);
INSERT INTO CITY VALUES ('VERAPAZ', 10);


/* MUNICIPIOS DE USULUTAN */
INSERT INTO CITY VALUES ('ALEGRIA', 11);
INSERT INTO CITY VALUES ('BERLIN', 11);
INSERT INTO CITY VALUES ('CALIFORNIA', 11);
INSERT INTO CITY VALUES ('CONCEPCION BATRES', 11);
INSERT INTO CITY VALUES ('EL TRIUNFO', 11);
INSERT INTO CITY VALUES ('EREGUAYQUIN', 11);
INSERT INTO CITY VALUES ('ESTANZUELAS', 11);
INSERT INTO CITY VALUES ('JIQUILISCO', 11);
INSERT INTO CITY VALUES ('JUCUAPA', 11);
INSERT INTO CITY VALUES ('JUCUARAN', 11);
INSERT INTO CITY VALUES ('MERCEDES UMAÑA', 11);
INSERT INTO CITY VALUES ('NUEVA GRANADA', 11);
INSERT INTO CITY VALUES ('OZATLAN', 11);
INSERT INTO CITY VALUES ('PUERTO EL TRIUNFO', 11);
INSERT INTO CITY VALUES ('SAN AGUSTIN', 11);
INSERT INTO CITY VALUES ('SAN BUENAVENTURA', 11);
INSERT INTO CITY VALUES ('SAN DIONISIO', 11);
INSERT INTO CITY VALUES ('SAN FRANCISCO JAVIER', 11);
INSERT INTO CITY VALUES ('SANTA ELENA', 11);
INSERT INTO CITY VALUES ('SANTA MARIA', 11);
INSERT INTO CITY VALUES ('SANTIAGO DE MARIA', 11);
INSERT INTO CITY VALUES ('TECAPAN', 11);
INSERT INTO CITY VALUES ('USULUTAN', 11);

/* MUNICIPIOS DE SAN MIGUEL */
INSERT INTO CITY VALUES ('CAROLINA', 12);
INSERT INTO CITY VALUES ('CHAPELTIQUE', 12);
INSERT INTO CITY VALUES ('CHINAMECA', 12);
INSERT INTO CITY VALUES ('CHIRILAGUA', 12);
INSERT INTO CITY VALUES ('CIUDAD BARRIOS', 12);
INSERT INTO CITY VALUES ('COMACARAN', 12);
INSERT INTO CITY VALUES ('EL TRANSITO', 12);
INSERT INTO CITY VALUES ('LOLOTIQUE', 12);
INSERT INTO CITY VALUES ('MONCAGUA', 12);
INSERT INTO CITY VALUES ('NUEVA GUADALUPE', 12);
INSERT INTO CITY VALUES ('NUEVO EDEN DE SAN JUAN', 12);
INSERT INTO CITY VALUES ('QUELEPA', 12);
INSERT INTO CITY VALUES ('SAN ANTONIO DEL MOSCO', 12);
INSERT INTO CITY VALUES ('SAN GERARDO', 12);
INSERT INTO CITY VALUES ('SAN JORGE', 12);
INSERT INTO CITY VALUES ('SAN LUIS DE LA REINA', 12);
INSERT INTO CITY VALUES ('SAN MIGUEL', 12);
INSERT INTO CITY VALUES ('SAN RAFAEL ORIENTE', 12);
INSERT INTO CITY VALUES ('SESORI', 12);
INSERT INTO CITY VALUES ('ULUAZAPA', 12);

/* MUNICIPIOS DE MORAZAN */
INSERT INTO CITY VALUES ('ARAMBALA', 13);
INSERT INTO CITY VALUES ('CACAOPERA', 13);
INSERT INTO CITY VALUES ('CHILANGA', 13);
INSERT INTO CITY VALUES ('CORINTO', 13);
INSERT INTO CITY VALUES ('DELICIAS DE CONCEPCION', 13);
INSERT INTO CITY VALUES ('EL DIVISADERO', 13);
INSERT INTO CITY VALUES ('EL ROSARIO', 13);
INSERT INTO CITY VALUES ('GUALOCOCTI', 13);
INSERT INTO CITY VALUES ('GUATAJIAGUA', 13);
INSERT INTO CITY VALUES ('JOATECA', 13);
INSERT INTO CITY VALUES ('JOCOAITIQUE', 13);
INSERT INTO CITY VALUES ('JOCORO', 13);
INSERT INTO CITY VALUES ('LOLOTIQUILLO', 13);
INSERT INTO CITY VALUES ('MEANGUERA', 13);
INSERT INTO CITY VALUES ('OSICALA', 13);
INSERT INTO CITY VALUES ('PERQUIN', 13);
INSERT INTO CITY VALUES ('SAN CARLOS', 13);
INSERT INTO CITY VALUES ('SAN FERNANDO', 13);
INSERT INTO CITY VALUES ('SAN FRANCISCO GOTERA', 13);
INSERT INTO CITY VALUES ('SAN ISIDRO', 13);
INSERT INTO CITY VALUES ('SAN SIMON', 13);
INSERT INTO CITY VALUES ('SENSEMBRA', 13);
INSERT INTO CITY VALUES ('SOCIEDAD', 13);
INSERT INTO CITY VALUES ('TOROLA', 13);
INSERT INTO CITY VALUES ('YAMABAL', 13);
INSERT INTO CITY VALUES ('YOLOAIQUIN', 13);

/* MUNICIPIOS DE LA UNION */
INSERT INTO CITY VALUES ('ANAMOROS', 14);
INSERT INTO CITY VALUES ('BOLIVAR', 14);
INSERT INTO CITY VALUES ('CONCEPCION DE ORIENTE', 14);
INSERT INTO CITY VALUES ('CONCHAGUA', 14);
INSERT INTO CITY VALUES ('EL CARMEN', 14);
INSERT INTO CITY VALUES ('EL SAUCE', 14);
INSERT INTO CITY VALUES ('INTIPUCA', 14);
INSERT INTO CITY VALUES ('LA UNION', 14);
INSERT INTO CITY VALUES ('LISLIQUE', 14);
INSERT INTO CITY VALUES ('MEANGUERA DEL GOLFO', 14);
INSERT INTO CITY VALUES ('NUEVA ESPARTA', 14);
INSERT INTO CITY VALUES ('PASAQUINA', 14);
INSERT INTO CITY VALUES ('POLOROS', 14);
INSERT INTO CITY VALUES ('SAN ALEJO', 14);
INSERT INTO CITY VALUES ('SAN JOSE', 14);
INSERT INTO CITY VALUES ('SANTA ROSA DE LIMA', 14);
INSERT INTO CITY VALUES ('YAYANTIQUE', 14);
INSERT INTO CITY VALUES ('YUCUAIQUIN', 14);


/*EMPLEADOS SANTA ANA*/
INSERT INTO EMPLOYEE VALUES ('Olimpia', 'Pacheco-Farré', 'opachecofarre@minsal.com.sv', 1, 1);
INSERT INTO EMPLOYEE VALUES ('Ernesto', 'Barroso Heredia', 'ebarrosoheredia@minsal.com.sv', 2, 2);
INSERT INTO EMPLOYEE VALUES ('Federico', 'Plaza Estévez', 'fplazaesteveza@minsal.com.sv', 2, 3);
INSERT INTO EMPLOYEE VALUES ('Alma', 'Vallejo-Pulido', 'avallejopulido@minsal.com.sv', 3, 4);
INSERT INTO EMPLOYEE VALUES ('Jose Carlos', 'Planas Exposito', 'jplanasexposito@minsal.com.sv', 3, 5);

INSERT INTO EMPLOYEE VALUES ('Matías', 'Delgado Tejedor', 'mdelgadotejedor@minsal.com.sv', 1, 6);
INSERT INTO EMPLOYEE VALUES ('Abigail', 'Ainoa de Aramburu', 'aainoadearamburu@minsal.com.sv', 2, 7);
INSERT INTO EMPLOYEE VALUES ('Nélida Isabel', 'Burgos Alfaro', 'nburgosalfaro@minsal.com.sv', 2, 8);
INSERT INTO EMPLOYEE VALUES ('Marcial', 'Beltrán Cobo', 'mbeltrancobo@minsal.com.sv', 3, 9);
INSERT INTO EMPLOYEE VALUES ('Tatiana Salud', 'Almeida Acuña', 'talmeidaacuna@minsal.com.sv', 3, 10);

INSERT INTO EMPLOYEE VALUES ('Faustino Nicolás', 'Escudero Perez', 'fescueroperez@minsal.com.sv', 1, 11);
INSERT INTO EMPLOYEE VALUES ('Viviana Diana', 'Maldonado Díaz', 'vmaldonadodiaz@minsal.com.sv', 2, 12);
INSERT INTO EMPLOYEE VALUES ('Teresa', 'Marín-Rosales', 'tmarinrosales@minsal.com.sv', 2, 13);
INSERT INTO EMPLOYEE VALUES ('Octavio', 'Garcia Uría', 'ogaricauria@minsal.com.sv', 3, 10);
INSERT INTO EMPLOYEE VALUES ('Flavio', 'Anaya Córdoba', '@minsal.com.sv', 3, 9);

/*EMPLEADOS SONSONATE*/
INSERT INTO EMPLOYEE VALUES ('Francisco Juanito', 'Company Iniesta', 'fcompanyiniesta@minsal.com.sv', 1, 14);
INSERT INTO EMPLOYEE VALUES ('Angelita', 'Muro Bayo', 'amurobayo@minsal.com.sv', 2, 15);
INSERT INTO EMPLOYEE VALUES ('Candelaria Aura', 'Casas Murcia', 'ccasasmurcia@minsal.com.sv', 2, 16);
INSERT INTO EMPLOYEE VALUES ('Nilda', 'Castillo', 'ncastillo@minsal.com.sv', 3, 17);
INSERT INTO EMPLOYEE VALUES ('Carlos', 'Marí Morell', 'cmarimorell@minsal.com.sv', 3, 18);

INSERT INTO EMPLOYEE VALUES ('Domingo', 'del Garcés', 'ddelgarces@minsal.com.sv', 1, 19);
INSERT INTO EMPLOYEE VALUES ('Roberto', 'Camino-Salom', 'rcaminosalom@minsal.com.sv', 2, 20);
INSERT INTO EMPLOYEE VALUES ('Priscila', 'Guijarro Alberola', 'pguijarroalberola@minsal.com.sv', 2, 21);
INSERT INTO EMPLOYEE VALUES ('Silvio', 'Rosselló Gomez', 'srosellogomez@minsal.com.sv', 3, 22);
INSERT INTO EMPLOYEE VALUES ('Olalla', 'Querol Duque', 'oquerolduque@minsal.com.sv', 3, 23);

INSERT INTO EMPLOYEE VALUES ('Ismael', 'Huguet Expósito', 'ihuguetexposito@minsal.com.sv', 1, 24);
INSERT INTO EMPLOYEE VALUES ('Evita', 'Solana Chaparro', 'esolanachaparro@minsal.com.sv', 2, 25);
INSERT INTO EMPLOYEE VALUES ('Ágata', 'Garcia Ferrera', 'agarciaferrera@minsal.com.sv', 2, 26);
INSERT INTO EMPLOYEE VALUES ('Sofía', 'Benet Mariscal', 'sbenetmariscal@minsal.com.sv', 3, 27);
INSERT INTO EMPLOYEE VALUES ('Mariano', 'Juárez', 'mjuarez@minsal.com.sv', 3, 28);

/*EMPLEADOS AHUACHAPAN*/ 
INSERT INTO EMPLOYEE VALUES ('Paca', 'Saez Saura', 'psaezsaura@minsal.com.sv', 1, 29);
INSERT INTO EMPLOYEE VALUES ('Calixta', 'Nebot Vélez', 'cnebotvelez@minsal.com.sv', 2, 30);
INSERT INTO EMPLOYEE VALUES ('Lisandro Moisés', 'Márquez Catalán', 'lmarquezcatalan@minsal.com.sv', 2, 31);
INSERT INTO EMPLOYEE VALUES ('Albano', 'de Bilbao', 'adebilbao@minsal.com.sv', 3, 32);
INSERT INTO EMPLOYEE VALUES ('Modesta', 'Rivera-Alvarez', 'mriveraalvarez@minsal.com.sv', 3, 33);
 
INSERT INTO EMPLOYEE VALUES ('Soraya', 'Ureña Peinado', 'surenapeinado@minsal.com.sv', 1, 34);
INSERT INTO EMPLOYEE VALUES ('Leyre', 'Torrens', 'ltorrens@minsal.com.sv', 2, 35);
INSERT INTO EMPLOYEE VALUES ('Laura Matilde', 'Vives Ureña', 'lvivesurena@minsal.com.sv', 2, 36);
INSERT INTO EMPLOYEE VALUES ('Nicolasa', 'Escamilla Varela', 'nescamillavarela@minsal.com.sv', 3, 37);
INSERT INTO EMPLOYEE VALUES ('Marino', 'Losa Cuevas', 'mlosacuevas@minsal.com.sv', 3, 37);
 
INSERT INTO EMPLOYEE VALUES ('Toribio', 'Dávila Pedro', 'tdavilapedro@minsal.com.sv', 1, 33);
INSERT INTO EMPLOYEE VALUES ('Vicente', 'Ruano-Tomé', 'vruanotome@minsal.com.sv', 2, 33);
INSERT INTO EMPLOYEE VALUES ('Inés', 'Roldán Coloma', 'iroldancoloma@minsal.com.sv', 2, 34);
INSERT INTO EMPLOYEE VALUES ('Judith', 'Macias Gargallo', 'jmaciasgargallo@minsal.com.sv', 3, 36);
INSERT INTO EMPLOYEE VALUES ('Bibiana', 'de Delgado', 'bdedelgado@minsal.com.sv', 3, 37);


/*EMPLEADOS LA LIBERTAD*/
INSERT INTO EMPLOYEE VALUES ('Nilo', 'del Pastor', 'ndelpastor@minsal.com.sv', 1, 41);
INSERT INTO EMPLOYEE VALUES ('Candelas', 'del Heredia', 'cdelheredia@minsal.com.sv', 2, 42);
INSERT INTO EMPLOYEE VALUES ('Onofre', 'Iglesias Cordero', 'oiglesiascordero@minsal.com.sv', 2, 43);
INSERT INTO EMPLOYEE VALUES ('María Ángeles', 'Uriarte Gimeno', 'muriartegimeno@minsal.com.sv', 3, 44);
INSERT INTO EMPLOYEE VALUES ('Leocadio', 'Cueto Iniesta', 'lcuetoiniesta@minsal.com.sv', 3, 45);

INSERT INTO EMPLOYEE VALUES ('Ramona', 'Carretero Malo', 'rcarreteromalo@minsal.com.sv', 1, 46);
INSERT INTO EMPLOYEE VALUES ('Gisela', 'de Codina', 'gdecodina@minsal.com.sv', 2, 47);
INSERT INTO EMPLOYEE VALUES ('Aránzazu', 'Escamilla Correa', 'aescamillacorrea@minsal.com.sv', 2, 48);
INSERT INTO EMPLOYEE VALUES ('Alma', 'Maldonado-Piña', 'amaldonadopina@minsal.com.sv', 3, 49);
INSERT INTO EMPLOYEE VALUES ('Rosenda', 'Rivas Valcárcel', 'rrivasvalcarcel@minsal.com.sv', 3, 50);
  
INSERT INTO EMPLOYEE VALUES ('Elba', 'Costa Barreda', 'ecostabarreda@minsal.com.sv', 1, 49);
INSERT INTO EMPLOYEE VALUES ('Íngrid', 'Adadia Torrecilla', 'iadadiatorrecilla@minsal.com.sv', 2, 51);
INSERT INTO EMPLOYEE VALUES ('María Luisa', 'Sanchez-Godoy', 'msanchezgodoy@minsal.com.sv', 2, 52);
INSERT INTO EMPLOYEE VALUES ('Fito', 'Leon Arteaga', 'fleonarteaga@minsal.com.sv', 3, 52);
INSERT INTO EMPLOYEE VALUES ('Hortensia Ariel', 'Ramón Cruz', 'hramoncruz@minsal.com.sv', 3, 53);

/*EMPLEADOS CHALATENANGO*/
INSERT INTO EMPLOYEE VALUES ('Ámbar Eva', 'Marco Cantero', 'amarcocentero@minsal.com.sv', 1, 64);
INSERT INTO EMPLOYEE VALUES ('Manola', 'Yuste', 'myuste@minsal.com.sv', 2, 66);
INSERT INTO EMPLOYEE VALUES ('Gracia', 'Roman Vilanova', 'gromanvilanova@minsal.com.sv', 2, 68);
INSERT INTO EMPLOYEE VALUES ('Jovita', 'Gelabert-Bonet', 'jgelabertbonet@minsal.com.sv', 3, 70);
INSERT INTO EMPLOYEE VALUES ('Ángel', 'Ibañez Almagro', 'aibanezalmagro@minsal.com.sv', 3, 72);

INSERT INTO EMPLOYEE VALUES ('David', 'Larrañaga Arana', 'dlarranagaarana@minsal.com.sv', 1, 74);
INSERT INTO EMPLOYEE VALUES ('Leandro', 'de Bautista', 'ldebautista@minsal.com.sv', 2, 76);
INSERT INTO EMPLOYEE VALUES ('Eric', 'Belmonte Núñez', 'ebelmontenunez@minsal.com.sv', 2, 80);
INSERT INTO EMPLOYEE VALUES ('Rosalva', 'Mata Carranza', 'rmatacarranza@minsal.com.sv', 3, 82);
INSERT INTO EMPLOYEE VALUES ('María', 'Somoza Saldaña', 'msomozasaldana@minsal.com.sv', 3, 84);

INSERT INTO EMPLOYEE VALUES ('Mohamed', 'Villar Zapata', 'mvillarzapata@minsal.com.sv', 1, 86);
INSERT INTO EMPLOYEE VALUES ('Borja', 'del Fortuny', 'bdelfortuny@minsal.com.sv', 2, 88);
INSERT INTO EMPLOYEE VALUES ('Dan Glauco', 'Cal Saldaña', 'dcalsaldana@minsal.com.sv', 2, 75);
INSERT INTO EMPLOYEE VALUES ('Teófila', 'Busquets Casas', 'tbusquetscasas@minsal.com.sv', 3, 73);
INSERT INTO EMPLOYEE VALUES ('Fátima', 'Nebot', 'fnebot@minsal.com.sv', 3, 89);

/*EMPLEADOS SAN SALVADOR*/
INSERT INTO EMPLOYEE VALUES ('María Luisa', 'Fortuny Canales', 'mfortunycanales@minsal.com.sv', 1, 109);
INSERT INTO EMPLOYEE VALUES ('Gilberto', 'Campo Segura', 'gcamposegura@minsal.com.sv', 2, 109);
INSERT INTO EMPLOYEE VALUES ('Donato', 'Fabra', 'dfabra@minsal.com.sv', 2, 109);
INSERT INTO EMPLOYEE VALUES ('Santiago', 'Tur Amorós', 'stusamoros@minsal.com.sv', 3, 106);
INSERT INTO EMPLOYEE VALUES ('Segismundo', 'del Coronado', 'sdelcoronado@minsal.com.sv', 3, 107);
 
INSERT INTO EMPLOYEE VALUES ('Belen', 'Baquero Almansa', 'bbaqueroalmansa@minsal.com.sv', 1, 106);
INSERT INTO EMPLOYEE VALUES ('Saturnino', 'Huguet Somoza', 'shuguetsomoza@minsal.com.sv', 2, 108);
INSERT INTO EMPLOYEE VALUES ('Asunción', 'Marcos', 'amarcos@minsal.com.sv', 2, 110);
INSERT INTO EMPLOYEE VALUES ('Teo', 'Vara Molina', 'tvaramolina@minsal.com.sv', 3, 104);
INSERT INTO EMPLOYEE VALUES ('Jenny', 'Pou Sanmartín', 'jpousanmartin@minsal.com.sv', 3, 105);
 
INSERT INTO EMPLOYEE VALUES ('Nydia', 'Alsina Amo', 'nalsinaamo@minsal.com.sv', 1, 107);
INSERT INTO EMPLOYEE VALUES ('Emperatriz', 'Calderón Múgica', 'ecalderonmugica@minsal.com.sv', 2, 109);
INSERT INTO EMPLOYEE VALUES ('Feliciana', 'Daza Segura', 'fdazasegura@minsal.com.sv', 2, 106);
INSERT INTO EMPLOYEE VALUES ('Maximiliano', 'Bernat-Almagro', 'mbernat-almagro@minsal.com.sv', 3, 105);
INSERT INTO EMPLOYEE VALUES ('Lucía Diez', 'Pozuelo', 'lpozuelo@minsal.com.sv', 3, 106);

/*EMPLEADOS CUSCATLAN*/
INSERT INTO EMPLOYEE VALUES ('Nazaret', 'Suarez', 'nsuarez@minsal.com.sv', 1, 128);
INSERT INTO EMPLOYEE VALUES ('Florentina', 'Ramírez Perez', 'framirezperez@minsal.com.sv', 2, 126);
INSERT INTO EMPLOYEE VALUES ('Fernanda', 'Elorza Velasco', 'felorzavelasco@minsal.com.sv', 2, 125);
INSERT INTO EMPLOYEE VALUES ('Vasco Josep', 'Guerra Cazorla', 'vguerracazorla@minsal.com.sv', 3, 125);
INSERT INTO EMPLOYEE VALUES ('Lope', 'Arenas Narváez', 'larenasnarvaez@minsal.com.sv', 3, 126);
 
INSERT INTO EMPLOYEE VALUES ('Valerio', 'Alberto Armas', 'valbertoarmas@minsal.com.sv', 1, 118);
INSERT INTO EMPLOYEE VALUES ('Mateo', 'Rovira Arroyo', 'mroviraarroyo@minsal.com.sv', 2, 119);
INSERT INTO EMPLOYEE VALUES ('Susana', 'Valera Cañete', 'svaleracanete@minsal.com.sv', 2, 119);
INSERT INTO EMPLOYEE VALUES ('Dimas', 'Mir Enríquez', 'dmirenriquez@minsal.com.sv', 3, 120);
INSERT INTO EMPLOYEE VALUES ('Juan José', 'de Guardia', 'jdeguardia@minsal.com.sv', 3, 120);

INSERT INTO EMPLOYEE VALUES ('Angélica', 'Rojas', 'arojas@minsal.com.sv', 1, 122);
INSERT INTO EMPLOYEE VALUES ('Dionisio', 'de Solera', 'ddesolera@minsal.com.sv', 2, 123);
INSERT INTO EMPLOYEE VALUES ('Ámbar', 'Tomé Alcázar', 'atomealcazar@minsal.com.sv', 2, 123);
INSERT INTO EMPLOYEE VALUES ('Aitana', 'Fonseca Solana', 'afonsecasolana@minsal.com.sv', 3, 126);
INSERT INTO EMPLOYEE VALUES ('Vicenta', 'Gilabert Palacio', 'vgilabertpalacio@minsal.com.sv', 3, 126);
 
/*EMPLEADOS LA PAZ*/
INSERT INTO EMPLOYEE VALUES ('José Luis', 'Ordóñez', 'jordonez@minsal.com.sv', 1, 131);
INSERT INTO EMPLOYEE VALUES ('Octavio', 'Pareja Canales', 'oparejacanales@minsal.com.sv', 2, 132);
INSERT INTO EMPLOYEE VALUES ('Edgardo', 'Prat Pedro', 'epratpedro@minsal.com.sv', 2, 133);
INSERT INTO EMPLOYEE VALUES ('Sandra', 'Palomo Marco', 'spalomomarco@minsal.com.sv', 3, 132);
INSERT INTO EMPLOYEE VALUES ('León', 'Noguera Bermúdez', 'lnoguerabermudez@minsal.com.sv', 3, 133);

INSERT INTO EMPLOYEE VALUES ('Micaela', 'Neira Blanch', 'mneirablanch@minsal.com.sv', 1, 145);
INSERT INTO EMPLOYEE VALUES ('Ramón', 'de Rebollo', 'rderebollo@minsal.com.sv', 2, 146);
INSERT INTO EMPLOYEE VALUES ('Perlita', 'Garay', 'pgaray@minsal.com.sv', 2, 145);
INSERT INTO EMPLOYEE VALUES ('Jordán', 'Chaparro Luís', 'jchaparroluis@minsal.com.sv', 3, 147);
INSERT INTO EMPLOYEE VALUES ('Ariel', 'Gomila Calleja', 'agomilacalleja@minsal.com.sv', 3, 143);

INSERT INTO EMPLOYEE VALUES ('Juan', 'Azcona Iglesias', 'jazconaiglesias@minsal.com.sv', 1, 140);
INSERT INTO EMPLOYEE VALUES ('Manola', 'Gelabert-Giralt', 'mdelabertgiralt@minsal.com.sv', 2, 148);
INSERT INTO EMPLOYEE VALUES ('Danilo', 'Lozano Lago', 'dlozanolago@minsal.com.sv', 2, 147);
INSERT INTO EMPLOYEE VALUES ('Cecilia', 'Sierra Maza', 'csieraamaza@minsal.com.sv', 3, 146);
INSERT INTO EMPLOYEE VALUES ('Rebeca', 'Rivas Rios', 'rrivasrios@minsal.com.sv', 3, 147);

/*EMPLEADOS CABAÑAS*/
INSERT INTO EMPLOYEE VALUES ('Josué', 'Mulet Corral', 'jmuletcorral@minsal.com.sv', 1, 153);
INSERT INTO EMPLOYEE VALUES ('Martirio', 'Morera Albero', 'mmoreraalbero@minsal.com.sv', 2, 154);
INSERT INTO EMPLOYEE VALUES ('Lina Socorro', 'Prado Acero', 'lpradoacero@minsal.com.sv', 2, 156);
INSERT INTO EMPLOYEE VALUES ('Lilia', 'Ramis-Pedrosa', 'lramispedrosa@minsal.com.sv', 3, 156);
INSERT INTO EMPLOYEE VALUES ('Concha', 'Quero Heredia', 'cqueroheredia@minsal.com.sv', 3, 157);

INSERT INTO EMPLOYEE VALUES ('Isaura', 'Sales Duque', 'isalesduque@minsal.com.sv', 1, 156);
INSERT INTO EMPLOYEE VALUES ('Claudia', 'de Galan', 'cdegalan@minsal.com.sv', 1, 157);
INSERT INTO EMPLOYEE VALUES ('Primitiva', 'de Hervás', 'pdehervas@minsal.com.sv', 1, 157);
INSERT INTO EMPLOYEE VALUES ('Isidoro', 'Puig Arnau', 'ipuigaranu@minsal.com.sv', 1, 158);
INSERT INTO EMPLOYEE VALUES ('Josefa', 'Echevarría Balaguer', 'jecheverriabalaguer@minsal.com.sv', 1, 156);

INSERT INTO EMPLOYEE VALUES ('Ofelia', 'Verdugo Murillo', 'overdugomurillo@minsal.com.sv', 1, 158);
INSERT INTO EMPLOYEE VALUES ('Máxima', 'de Andrade', 'mdeandrade@minsal.com.sv', 1, 159);
INSERT INTO EMPLOYEE VALUES ('Luis', 'de Casares', 'ldecasares@minsal.com.sv', 1, 157);
INSERT INTO EMPLOYEE VALUES ('Celso', 'del Blazquez', 'cdelblazquez@minsal.com.sv', 1, 158);
INSERT INTO EMPLOYEE VALUES ('Antonio', 'Chaparro Cortes', 'achaparrocortes@minsal.com.sv', 1, 159);

/*EMPLEADOS SAN VICENTE*/
INSERT INTO EMPLOYEE VALUES ('Rosaura', 'Narváez-Coronado', 'rnarvaezcoronado@minsal.com.sv', 1, 162);
INSERT INTO EMPLOYEE VALUES ('Leocadio Amor', 'Pareja Morales', 'lparejamorales@minsal.com.sv', 2, 163);
INSERT INTO EMPLOYEE VALUES ('Horacio', 'Viana-Riera', 'hvianarivera@minsal.com.sv', 2, 166);
INSERT INTO EMPLOYEE VALUES ('Marc', 'Franch Oliveras', 'mfrancholiveras@minsal.com.sv', 3, 167);
INSERT INTO EMPLOYEE VALUES ('Ramona', 'Bou Nieto', 'rbounieto@minsal.com.sv', 3, 163);

INSERT INTO EMPLOYEE VALUES ('Victoria', 'Arce-Ros', 'varceros@minsal.com.sv', 1, 163);
INSERT INTO EMPLOYEE VALUES ('Aránzazu', 'Marín Mínguez', 'amarinminguez@minsal.com.sv', 2, 166);
INSERT INTO EMPLOYEE VALUES ('Roberta', 'de Bartolomé', 'rdebartolome@minsal.com.sv', 2, 167);
INSERT INTO EMPLOYEE VALUES ('Aarón', 'Ricart Moya', 'aricartmoya@minsal.com.sv', 3, 172);
INSERT INTO EMPLOYEE VALUES ('Nazaret', 'Morante Gomis', 'nmorantegomis@minsal.com.sv', 3, 172);

INSERT INTO EMPLOYEE VALUES ('Trini Salud', 'Olivé Alvarado', 'tolivealvarado@minsal.com.sv', 1, 172);
INSERT INTO EMPLOYEE VALUES ('Sandalio', 'de Maza', 'sdemaza@minsal.com.sv', 2, 172);
INSERT INTO EMPLOYEE VALUES ('Bonifacio', 'Ferrando Diez', 'bferrandodiez@minsal.com.sv', 2, 171);
INSERT INTO EMPLOYEE VALUES ('David', 'Nebot Lopez', 'dnebotlopez@minsal.com.sv', 3, 170);
INSERT INTO EMPLOYEE VALUES ('Samuel', 'Camacho Lluch', 'scamacholluch@minsal.com.sv', 3, 170);

/*EMPLEADOS USULUTAN*/
INSERT INTO EMPLOYEE VALUES ('Carol', 'Cold Freeze', 'ccoldfreeze@minsal.com.sv', 1, 174);
INSERT INTO EMPLOYEE VALUES ('Armen', 'Scafold lee', 'ascafoldlee@minsal.com.sv', 2, 175);
INSERT INTO EMPLOYEE VALUES ('lean', 'Fruit Ramm', 'lfruitramm@minsal.com.sv', 2, 176);
INSERT INTO EMPLOYEE VALUES ('Armin', 'God SNK', 'agodsnk@minsal.com.sv', 3, 177);
INSERT INTO EMPLOYEE VALUES ('Bartolo', 'Skull Trum', 'bskulltrum@minsal.com.sv', 3, 178);

INSERT INTO EMPLOYEE VALUES ('Lemar', 'Tobar Guzman', 'ltobarguzman@minsal.com.sv', 1, 179);
INSERT INTO EMPLOYEE VALUES ('Arlis', 'Varela Asturias', 'avarelaasturias@minsal.com.sv', 2, 180);
INSERT INTO EMPLOYEE VALUES ('Luisa', 'Campos Fuentes ', 'lcamposfuentes@minsal.com.sv', 2, 181);
INSERT INTO EMPLOYEE VALUES ('Rocio', 'Flores Martinez', 'rfloresmartinez@minsal.com.sv', 3, 182);
INSERT INTO EMPLOYEE VALUES ('Xavier', 'Palacios Guardado', 'xpalaciosguardado@minsal.com.sv', 3, 183);

INSERT INTO EMPLOYEE VALUES ('Antonella', 'Caramutti Santos', 'acaramuttisantos@minsal.com.sv', 1, 184);
INSERT INTO EMPLOYEE VALUES ('Karyna', 'Rodriguez Osorio', 'krodriguezosorio@minsal.com.sv', 2, 185);
INSERT INTO EMPLOYEE VALUES ('Katya', 'Garcia Chorro', 'kgarciachorro@minsal.com.sv', 2, 186);
INSERT INTO EMPLOYEE VALUES ('Marcela', 'Melendez Martinez', 'mmelendezmartinez@minsal.com.sv', 3, 187);
INSERT INTO EMPLOYEE VALUES ('Tatiana', 'Romero de Barrera', 'tromerodebarrera@minsal.com.sv', 3, 188);

/*EMPLEADOS SAN MIGUEL*/
INSERT INTO EMPLOYEE VALUES ('Edson', 'Palacios Torres', 'epalaciostorres@minsal.com.sv', 1, 197);
INSERT INTO EMPLOYEE VALUES ('Fredy', 'Hernandez', 'fhernandez@minsal.com.sv', 2, 198);
INSERT INTO EMPLOYEE VALUES ('Lea', 'Cruice Rudiguer', 'lcruicerudiguer@minsal.com.sv', 2, 199);
INSERT INTO EMPLOYEE VALUES ('Aaron', 'Good Rogel', 'agoodrogel@minsal.com.sv', 3, 200);
INSERT INTO EMPLOYEE VALUES ('Marcos', 'Rogel Zepeda', 'mrogelzepeda@minsal.com.sv', 3, 201);

INSERT INTO EMPLOYEE VALUES ('Nach', 'De España', 'ndeespana@minsal.com.sv', 1, 202);
INSERT INTO EMPLOYEE VALUES ('Ambkor', 'Asturias', 'aasturias@minsal.com.sv', 2, 203);
INSERT INTO EMPLOYEE VALUES ('Javier', 'Sinfuentes Gonzales', 'jsinfuentesgonzalez@minsal.com.sv', 2, 204);
INSERT INTO EMPLOYEE VALUES ('Adriana', 'Montoya Fierro', 'amontoyafierro@minsal.com.sv', 3, 205);
INSERT INTO EMPLOYEE VALUES ('Juan', 'Buendia Palacios', 'jbuendiapalacios@minsal.com.sv', 3, 206);

INSERT INTO EMPLOYEE VALUES ('Antuane', 'Griezman Santos', 'agriezmansantos@minsal.com.sv', 1, 207);
INSERT INTO EMPLOYEE VALUES ('Karla', 'Flores Barrios', 'kfloresbarrios@minsal.com.sv', 2, 208);
INSERT INTO EMPLOYEE VALUES ('Winona', 'Karlson', 'wkarlson@minsal.com.sv', 2, 209);
INSERT INTO EMPLOYEE VALUES ('Kevin', 'Reyes Melendez', 'kreyesmelendez@minsal.com.sv', 3, 210);
INSERT INTO EMPLOYEE VALUES ('Clarissa', 'Claramount Bernal', 'cclaramountbernal@minsal.com.sv', 3, 211);

/* EMPLEADOS MORAZAN*/
INSERT INTO EMPLOYEE VALUES ('Maria del Carmen', 'Perez Acosta', 'mperezacosta@minsal.com.sv', 1, 243);
INSERT INTO EMPLOYEE VALUES ('Jose Pablo', 'Emilio Escobar', 'jemilioescobar@minsal.com.sv', 2, 243);
INSERT INTO EMPLOYEE VALUES ('Jacinto Alejandro', 'Escobar Galindo', 'jescobargalindo@minsal.com.sv', 2, 243);
INSERT INTO EMPLOYEE VALUES ('Camila Paola', 'Ruballos Mendoza', 'cruballosmendoza@minsal.com.sv', 3, 244);
INSERT INTO EMPLOYEE VALUES ('Sonya Maria', 'Albeño Flores', 'salbeñoflores@minsal.com.sv', 3, 244);

INSERT INTO EMPLOYEE VALUES ('Alma Marcela', 'Gozo Peña', 'agozopeña@minsal.com.sv', 1, 244);
INSERT INTO EMPLOYEE VALUES ('Benito Carmelo', 'Hernandez Escobar', 'bhernandezescobar@minsal.com.sv', 2, 245);
INSERT INTO EMPLOYEE VALUES ('Juan Carlos', 'Gonzales Diaz', 'jgonzalesdiaz@minsal.com.sv', 2, 245);
INSERT INTO EMPLOYEE VALUES ('Diego Javier', 'Flores Gomez', 'dfloresgomez@minsal.com.sv', 3, 245);
INSERT INTO EMPLOYEE VALUES ('Fabiana Eugenia', 'Silhy Sanchez', 'fsilhysanchez@minsal.com.sv', 3, 246);

INSERT INTO EMPLOYEE VALUES ('Gloria Rosa', 'Ayllon Fajardo', 'gayllonfajardo@minsal.com.sv', 1, 246);
INSERT INTO EMPLOYEE VALUES ('Catalina Morelo', 'Castella Cuellar', 'ccastellacuellar@minsal.com.sv', 2, 246);
INSERT INTO EMPLOYEE VALUES ('Angel Marcelo', 'Gongora Bautista', 'agongorabautista@minsal.com.sv', 2, 247);
INSERT INTO EMPLOYEE VALUES ('Francisco Alberto', 'Poveda Leyva', 'fpovedaleyva@minsal.com.sv', 3, 247);
INSERT INTO EMPLOYEE VALUES ('Cristobal Camilo', 'Santos Pina', 'csantospina@minsal.com.sv', 3, 247);

/* EMPLEADOS LA UNION */
INSERT INTO EMPLOYEE VALUES ('Ulices Roberto', 'Diaz Antolin', 'udiazantolin@minsal.com.sv', 1, 248);
INSERT INTO EMPLOYEE VALUES ('Jose Ernesto', 'Melendez Amor', 'jmelendezamor@minsal.com.sv', 2, 249);
INSERT INTO EMPLOYEE VALUES ('Hector Martin', 'Guardia Paredes', 'hguardiaparedes@minsal.com.sv', 2, 249);
INSERT INTO EMPLOYEE VALUES ('Armando Luis', 'Paredes Espina', 'aparedesespina@minsal.com.sv', 3, 250);
INSERT INTO EMPLOYEE VALUES ('Sandra Teresa', 'Angulo Pulido', 'sandulopulido@minsal.com.sv', 3, 250);

INSERT INTO EMPLOYEE VALUES ('Luisa Alicia', 'Ramiro Moya', 'lramiromoya@minsal.com.sv', 1, 251);
INSERT INTO EMPLOYEE VALUES ('Milagros Silvia', 'Silva Garzon', 'msilvagarzon@minsal.com.sv', 2, 260);
INSERT INTO EMPLOYEE VALUES ('Nicole Irene', 'Troya Esteve', 'ntroyaesteve@minsal.com.sv', 2, 252);
INSERT INTO EMPLOYEE VALUES ('Angeles Victoria', 'Serrano Aguila', 'aserranoanguila@minsal.com.sv', 3, 253);
INSERT INTO EMPLOYEE VALUES ('Jose Maria', 'Moure Llorca', 'jmourellorca@minsal.com.sv', 3, 254);

INSERT INTO EMPLOYEE VALUES ('Antonio Jesus', 'Velez Monreal', 'avelezmonreal@minsal.com.sv', 1, 255);
INSERT INTO EMPLOYEE VALUES ('Julio Julian', 'Albarracin Alberola', 'jalbarracinalberola@minsal.com.sv', 2, 256);
INSERT INTO EMPLOYEE VALUES ('Maria Isabel', 'Petit Cañas', 'mpetitcañas@minsal.com.sv', 2, 257);
INSERT INTO EMPLOYEE VALUES ('Rosario Dolores', 'Marmol Osorio', 'rmarmolosorio@minsal.com.sv', 3, 258);
INSERT INTO EMPLOYEE VALUES ('Gonzalo Felix', 'Sapico Orta', 'gsapicoorta@minsal.com.sv', 3, 259);

/*CABINAS*/
/*CABINAS SANTA ANA*/
INSERT INTO CABIN VALUES ('cabinacoatepeque@minsal.com.sv', 3);
INSERT INTO CABIN VALUES ('cabinametapan@minsal.com.sv', 7);
INSERT INTO CABIN VALUES ('cabinasantaana@minsal.com.sv', 10);

/*CABINAS SONSONATE*/
INSERT INTO CABIN VALUES ('cabinasonsonate@minsal.com.sv', 27);
INSERT INTO CABIN VALUES ('cabinaacajutla@minsal.com.sv', 14);
INSERT INTO CABIN VALUES ('cabinaizalco@minsal.com.sv', 18);

/*CABINAS AHUACHAPAN*/
INSERT INTO CABIN VALUES ('cabinaahuachapan@minsal.com.sv', 29);
INSERT INTO CABIN VALUES ('cabinaapaneca@minsal.com.sv', 30);
INSERT INTO CABIN VALUES ('cabinatacuba@minsal.com.sv', 39);

/*CABINAS LA LIBERTAD*/
INSERT INTO CABIN VALUES ('cabinasantatecla@minsal.com.sv', 50);
INSERT INTO CABIN VALUES ('cabinaantiguocuscatlan@minsal.com.sv', 41);
INSERT INTO CABIN VALUES ('cabinanuevocuscatlan@minsal.com.sv', 51);

/*CABINAS CHALATENANGO*/
INSERT INTO CABIN VALUES ('cabinachalatenango@minsal.com.sv', 65);
INSERT INTO CABIN VALUES ('cabinanuevaconcepcion@minsal.com.sv', 76);
INSERT INTO CABIN VALUES ('cabinacomalapa@minsal.com.sv', 66);

/*CABINAS SAN SALVADOR*/
INSERT INTO CABIN VALUES ('cabinasansalvador@minsal.com.sv', 109);
INSERT INTO CABIN VALUES ('cabinamejicanos@minsal.com.sv', 103);
INSERT INTO CABIN VALUES ('cabinasoyapango@minsal.com.sv', 112);

/*CABINAS CUSCATLAN*/
INSERT INTO CABIN VALUES ('cabinacojutepeque@minsal.com.sv', 115);
INSERT INTO CABIN VALUES ('cabinasuchitoto@minsal.com.sv', 128);
INSERT INTO CABIN VALUES ('cabinaelcarment@minsal.com.sv', 116);

/*CABINAS LA PAZ*/
INSERT INTO CABIN VALUES ('cabinaolocuilta@minsal.com.sv', 134);
INSERT INTO CABIN VALUES ('cabinazacatecoluca@minsal.com.sv', 151);
INSERT INTO CABIN VALUES ('cabinasanfranchinameca@minsal.com.sv', 138);

/*CABINAS CABAÑAS*/
INSERT INTO CABIN VALUES ('cabinailobasco@minsal.com.sv', 155);
INSERT INTO CABIN VALUES ('cabinasensuntepeque@minsal.com.sv', 158);
INSERT INTO CABIN VALUES ('cabinajutiapa@minsal.com.sv', 156);

/*CABINAS SAN VICENTE*/
INSERT INTO CABIN VALUES ('cabinasanvicente@minsal.com.sv', 168);
INSERT INTO CABIN VALUES ('cabinasansebastian@minsal.com.sv', 167);
INSERT INTO CABIN VALUES ('cabinaapastepeque@minsal.com.sv', 161);

/*CABINAS USULUTAN*/
INSERT INTO CABIN VALUES ('cabinausulutan@minsal.com.sv', 196);
INSERT INTO CABIN VALUES ('cabinajiquilisco@minsal.com.sv', 181);
INSERT INTO CABIN VALUES ('cabinapuertoeltriunfo@minsal.com.sv', 187);

/*CABINAS SAN MIGUEL*/
INSERT INTO CABIN VALUES ('cabinaciudadbarrios@minsal.com.sv', 201);
INSERT INTO CABIN VALUES ('cabinasanmiguel@minsal.com.sv', 213);
INSERT INTO CABIN VALUES ('cabinamoncagua@minsal.com.sv', 205);

/*CABINAS MORAZAN*/
INSERT INTO CABIN VALUES ('cabinacacaopera@minsal.com.sv', 218);
INSERT INTO CABIN VALUES ('cabinaperquin@minsal.com.sv', 232);
INSERT INTO CABIN VALUES ('cabinasanisidro@minsal.com.sv', 236);

/*CABINAS LA UNION*/
INSERT INTO CABIN VALUES ('cabinalaunion@minsal.com.sv', 250);
INSERT INTO CABIN VALUES ('cabinaelsauce@minsal.com.sv', 248);
INSERT INTO CABIN VALUES ('cabinaintipuca@minsal.com.sv', 249);

/*INFORMACION DE LOGIN*/

INSERT INTO LOGIN_INFO VALUES('opachecofarre','opachecofarre',1);
INSERT INTO LOGIN_INFO VALUES('mdelgadotejedor','mdelgadotejedor',6);
INSERT INTO LOGIN_INFO VALUES('fescuderoperez','fescuderoperez',11);

INSERT INTO LOGIN_INFO VALUES('fcompanyiniesta','fcompanyiniesta',16);
INSERT INTO LOGIN_INFO VALUES('ddelgarces','ddelgarces',21);
INSERT INTO LOGIN_INFO VALUES('ihuguetexposito','ihuguetexposito',26);

INSERT INTO LOGIN_INFO VALUES('psaezsaura','psaezsaura',31);
INSERT INTO LOGIN_INFO VALUES('surenapeinado','surenapeinado',36);
INSERT INTO LOGIN_INFO VALUES('tdavilapedro','tdavilapedro',41);

INSERT INTO LOGIN_INFO VALUES('ndelpastor','ndelpastor',46);
INSERT INTO LOGIN_INFO VALUES('rcarreteromalo','rcarreteromalo',51);
INSERT INTO LOGIN_INFO VALUES('ecostabarreda','ecostabarreda',56);

INSERT INTO LOGIN_INFO VALUES('amarcocantero','amarcocantero',61);
INSERT INTO LOGIN_INFO VALUES('dlarranagaarana','dlarranagaarana',66);
INSERT INTO LOGIN_INFO VALUES('mvillarzapata','mvillarzapata',71);

INSERT INTO LOGIN_INFO VALUES('mfortunycanales','mfortunycanales',76);
INSERT INTO LOGIN_INFO VALUES('bbaqueroalmansa','bbaqueroalmansa',81);
INSERT INTO LOGIN_INFO VALUES('nalsinaamo','nalsinaamo',86);

INSERT INTO LOGIN_INFO VALUES('nsuarez','nsuarez',91);
INSERT INTO LOGIN_INFO VALUES('valbertoarmas','valbertoarmas',96);
INSERT INTO LOGIN_INFO VALUES('arojas','arojas',101);

INSERT INTO LOGIN_INFO VALUES('jordonez','jordonez',106);
INSERT INTO LOGIN_INFO VALUES('mneirablanch','mneirablanch',111);
INSERT INTO LOGIN_INFO VALUES('jazconaiglesias','jazconaiglesias',116);

INSERT INTO LOGIN_INFO VALUES('jmuletcorral','jmuletcorral',121);
INSERT INTO LOGIN_INFO VALUES('isalesduque','isalesduque',126);
INSERT INTO LOGIN_INFO VALUES('overdugomurillo','overdugomurillo',131);

INSERT INTO LOGIN_INFO VALUES('rnarvaezcoronado','rnarvaezcoronado',136);
INSERT INTO LOGIN_INFO VALUES('varceros','varceros',141);
INSERT INTO LOGIN_INFO VALUES('tolivealvarado','tolivealvarado',146);

INSERT INTO LOGIN_INFO VALUES('ccoldfreeze','ccoldfreeze',151);
INSERT INTO LOGIN_INFO VALUES('ltobarguzman','ltobarguzman',156);
INSERT INTO LOGIN_INFO VALUES('acaramuttisantos','acaramuttisantos',161);

INSERT INTO LOGIN_INFO VALUES('epalaciostorres','epalaciostorres',166);
INSERT INTO LOGIN_INFO VALUES('ndeespana','ndeespana',171);
INSERT INTO LOGIN_INFO VALUES('agriezmansantos','agriezmansantos',176);

INSERT INTO LOGIN_INFO VALUES('mperezacosta','mperezacosta',181);
INSERT INTO LOGIN_INFO VALUES('agozopena','agozopena',186);
INSERT INTO LOGIN_INFO VALUES('gayllonfajardo','gayllonfajardo',191);

INSERT INTO LOGIN_INFO VALUES('udiazantolin','udiazantolin',196);
INSERT INTO LOGIN_INFO VALUES('lramiromoya','lramiromoya',201);
INSERT INTO LOGIN_INFO VALUES('avelezmonreal','avelezmonreal',206);


