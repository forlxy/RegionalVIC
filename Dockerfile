FROM microsoft/aspnetcore
LABEL name="RegionalVIC"
ENTRYPOINT ["dotnet", "RegionalVIC.dll"]
ARG source=.
WORKDIR /app
EXPOSE 80
COPY $source .