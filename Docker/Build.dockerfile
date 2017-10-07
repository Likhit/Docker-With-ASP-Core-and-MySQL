FROM microsoft/aspnetcore-build:2.0
## Can be Debug or Release.
ARG BUILD_CONFIG=Debug
ARG BUILDER_VERSION=0.0.1
LABEL maintainer=some_email@email_server.com \
    Name=webapp-build-${BUILD_CONFIG} \
    Version=${BUILDER_VERSION}
## Will be the path mapped to the external volume.
ARG BUILD_LOCATION=/app/out
ENV NUGET_XMLDOC_MODE skip
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . /app
RUN dotnet publish --output ${BUILD_LOCATION} --configuration ${BUILD_CONFIG}