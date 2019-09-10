
# FROM microsoft/dotnet:2.2-sdk as build

# LABEL name="regionalvic"
# ARG BUILDCONFIG=RELEASE
# ARG VERSION=1.0.0

# COPY RegionalVIC.csproj /build/

# RUN dotnet restore ./build/RegionalVIC.csproj

# COPY ../build/
# WORKDIR /build/
# RUN dotnet publish ./RegionalVIC.csproj -c $BUILDCONFIG -o out /p:Version=$VERSION

# FROM microsoft/dotnet:2.2-aspnetcore-runtime
# WORKDIR /app

# COPY --from=build /build/out .
# ENTRYPOINT ["dotnet", "RegionalVIC.dll"]

# EXPOSE 80

# FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
# WORKDIR /app

# # Copy csproj and restore as distinct layers
# COPY *.csproj ./
# RUN dotnet restore

# # Copy everything else and build
# COPY . ./
# RUN dotnet publish -c Release -o out

# # Build runtime image
# FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "RegionalVIC.dll"]


FROM microsoft/aspnetcore
LABEL name="RegionalVIC"
ENTRYPOINT ["dotnet", "RegionalVIC.dll"]
ARG source=.
WORKDIR /app
EXPOSE 80
COPY $source .