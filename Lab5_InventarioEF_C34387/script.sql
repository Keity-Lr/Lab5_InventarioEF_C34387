CREATE TABLE Productos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Precio REAL NOT NULL,
    Categoria TEXT,
    FechaIngreso TEXT,
    Activo INTEGER NOT NULL
);