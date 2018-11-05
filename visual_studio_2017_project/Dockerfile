FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51518
EXPOSE 44305

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Gamma/Gamma.csproj", "Gamma/"]
COPY . .
RUN dotnet restore "Gamma/Gamma.csproj"
WORKDIR "/src/Gamma"
RUN dotnet build "Gamma.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Gamma.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Gamma.dll"]