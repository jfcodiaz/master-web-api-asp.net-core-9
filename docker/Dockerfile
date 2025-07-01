# Usa la imagen oficial del SDK .NET 9.0 Preview 2
FROM mcr.microsoft.com/dotnet/sdk:9.0.100-preview.2 AS build

# Establece el directorio de trabajo
WORKDIR /app

# Copia todo el contenido al contenedor
COPY . .

# Puedes dejarlo solo para ejecución manual o descomentar para compilación automática:
# RUN dotnet restore
# RUN dotnet build --configuration Release

CMD [ "bash" ]
