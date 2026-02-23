# Proyecto RPG - Código Inicial

Este es el código base que deberás refactorizar y documentar como parte de la Tarea Grupal UT04.

## Estructura del Proyecto

El proyecto contiene una jerarquía de clases que representan personajes de un videojuego RPG:

- **Personaje** (clase base)
  - **Guerrero** (hereda de Personaje)
    - **Berserker** (hereda de Guerrero)
  - **Mago** (hereda de Personaje)
    - **Nigromante** (hereda de Mago)

## Cómo ejecutar

### Opción 1: Visual Studio
1. Abre Visual Studio
2. File → Open → Project/Solution
3. Selecciona el archivo `ProyectoRPG.csproj`
4. Presiona F5 para ejecutar

### Opción 2: Línea de comandos
```bash
dotnet run
```

## Archivos del proyecto

- `Personaje.cs` - Clase base que representa cualquier personaje
- `Guerrero.cs` - Especialización de personaje enfocada en combate cuerpo a cuerpo
- `Berserker.cs` - Guerrero que puede entrar en furia
- `Mago.cs` - Especialización de personaje que usa magia
- `Nigromante.cs` - Mago especializado en magia oscura
- `Program.cs` - Clase principal con el método Main

## Notas

Este código **NO está refactorizado ni documentado**. Es tu punto de partida para aplicar las técnicas de refactorización y documentación que has aprendido.
