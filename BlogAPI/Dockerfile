FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["BlogAPI/BlogAPI.csproj", "BlogAPI/"]
RUN dotnet restore "BlogAPI/BlogAPI.csproj"
COPY . .
WORKDIR "/src/BlogAPI"
RUN dotnet build "BlogAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BlogAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BlogAPI.dll"]