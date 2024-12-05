/*PIELES*/
INSERT INTO TiposDePiel (Nombre, Descripcion)
VALUES 
('Piel Grasa', 'Produce un exceso de sebo, lo que da un aspecto brillante y poros visibles.'),
('Piel Seca', 'Tiene falta de hidratación, lo que la hace áspera y opaca.'),
('Piel Mixta', 'Tiene áreas grasas (zona T) y otras secas.'),
('Piel Normal', 'Equilibrada, con buena hidratación y sin imperfecciones visibles.'),
('Piel Sensible', 'Reacciona fácilmente a productos y factores externos, causando enrojecimiento e irritación.');



/*PRODUCTOS*/
INSERT INTO Productos (Nombre, TipoDePielId, Categoria, Precio, LugarDeCompra)
VALUES 
('Limpiador en gel', 1, 'Económica', 10.50, 'Farmacias Arrocha'),
('Crema hidratante ligera', 1, 'Premium', 25.00, 'Farmacias Arrocha'),
('Tónico matificante', 1, 'Económica', 8.75, 'Super 99'),
('Aceite limpiador', 2, 'Premium', 30.50, 'Novey'),
('Crema nutritiva', 2, 'Económica', 15.00, 'Riba Smith'),
('Gel hidratante', 3, 'Premium', 20.99, 'Farmacias Arrocha'),
('Protector solar matificante', 3, 'Económica', 12.50, 'Super 99'),
('Serum antioxidante', 4, 'Premium', 40.00, 'Farmacias Arrocha'),
('Agua micelar', 5, 'Económica', 7.99, 'Riba Smith'),
('Crema calmante', 5, 'Premium', 35.00, 'Novey');


/*RUTINAS*/
INSERT INTO Rutinas (TipoDePielId, Categoria)
VALUES 
(1, 'Económica'),
(1, 'Premium'),
(2, 'Económica'),
(2, 'Premium'),
(3, 'Económica'),
(3, 'Premium'),
(4, 'Económica'),
(4, 'Premium'),
(5, 'Económica'),
(5, 'Premium');
