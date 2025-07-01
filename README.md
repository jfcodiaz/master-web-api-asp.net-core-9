# Master Web API ASP Net Core 9

EL presente repositorio contine las practicas y notas que realicé del curso de [Master Web API ASP Net Core 9](https://www.udemy.com/course/webapi-net/learn/lecture/43246538#overview)
### Notas

#### Inicializar Projecto 

Se debe de crear una solución que puede contener varios proyecto
Se debe de crear el proyecto web api
```bash
# Crear solucion

# Crear directorio de la solucion
mkdir MasterNet 

# Crear archivo de la solción
dotnet new sln --name MasterNet

# Crear proyecto web api
dotnet new webapi -o src/MasterNet.webApi

# Agregar el proyecto a la solucion
dotnet sln add src/MasterNet.webApi/MasterNet.webApi.csproj 

# Si todo fue bien se podra hacer un build sin problemas
dotnet build

# Correr el proyecto en local :

dotnet run --project src/MasterNet.webApi

```

