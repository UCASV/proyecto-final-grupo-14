

/*1.1*/SELECT COUNT(VACCINATION_PROCESS.id) AS 'TOTAL DE PERSONAS VACUNADAS' FROM VACCINATION_PROCESS;
/*1.2*/SELECT COUNT(VACCINATION_PROCESS.id) AS 'PERSONAS CON UNA DOSIS' FROM VACCINATION_PROCESS 
WHERE ;
/*1.3*/SELECT COUNT(VACCINATION_PROCESS.id) AS 'PERSONAS CON UNA DOSIS' FROM VACCINATION_PROCESS 
WHERE;

/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'DOLOR E/A INYECCION' FROM SIDE_EFFECTS WHERE symptom_id = 1;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'SENSIBILIDAD E/A INYECCION' FROM SIDE_EFFECTS WHERE symptom_id = 2;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'ENROJECIMIENTO E/A INYECCION' FROM SIDE_EFFECTS WHERE symptom_id = 3;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'FATIGA' FROM SIDE_EFFECTS WHERE symptom_id = 4;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'DOLOR DE CABEZA' FROM SIDE_EFFECTS WHERE symptom_id = 5;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'FIEBRE' FROM SIDE_EFFECTS WHERE symptom_id = 6;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'MIALGIA' FROM SIDE_EFFECTS WHERE symptom_id = 7;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'ARTRALGIA' FROM SIDE_EFFECTS WHERE symptom_id = 8;
/*1.1*/ SELECT COUNT(SIDE_EFFECTS.symptom_id) AS 'ANAFILAXIA' FROM SIDE_EFFECTS WHERE symptom_id = 9;

SELECT * FROM SIDE_EFFECTS;
INSERT INTO SIDE_EFFECTS VALUES (6, '10:15');



/*: (1) personas vacunadas en total, solo con una dosis y
con ambas dosis; (2) estadísticas de los efectos secundarios; (3) gráfico que refleje la eficiencia
del proceso de vacunación, haciendo uso de los registros de hora obtenidos en los pasos 2 y 4
del proceso. El gráfico debe separar la información en los rangos: 15 minutos, entre 15 y 30
minutos, entre 30 minutos y una hora, y finalmente, de una hora*/