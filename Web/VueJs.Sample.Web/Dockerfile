FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Web/VueJs.Sample.Web/VueJs.Sample.Web.csproj", "Web/VueJs.Sample.Web/"]
RUN dotnet restore "Web/VueJs.Sample.Web/VueJs.Sample.Web.csproj"
COPY . .
WORKDIR "/src/Web/VueJs.Sample.Web"
RUN dotnet build "VueJs.Sample.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VueJs.Sample.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VueJs.Sample.Web.dll"]