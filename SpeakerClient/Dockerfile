FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY SpeakerClient.csproj .
# RUN dotnet restore "SpeakerClient.csproj"
COPY . .
RUN dotnet build "SpeakerClient.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SpeakerClient.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/SpeakerClient/dist .
COPY nginx.conf /etc/nginx/nginx.conf