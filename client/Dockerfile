FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY client.csproj .
# RUN dotnet restore "client.csproj"
COPY . .
RUN dotnet build "client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "client.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/client/dist .
COPY nginx.conf /etc/nginx/nginx.conf