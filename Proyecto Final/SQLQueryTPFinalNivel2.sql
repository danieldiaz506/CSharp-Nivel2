SELECT * FROM ARTICULOS
--SELECT * FROM CATEGORIAS
--SELECT * FROM MARCAS

--SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id

--INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES ('', '', '', 1, 1, '', 1) 

--UPDATE ARTICULOS SET Codigo = '', Nombre = '', Descripcion = '', IdMarca = 1, IdCategoria = 1, ImagenUrl = '', Precio = 1 WHERE Id = 11

--DELETE FROM ARTICULOS WHERE Id = 11

--SELECT Id, Descripcion FROM CATEGORIAS

--SELECT Id, Descripcion FROM MARCAS