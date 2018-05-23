FROM microsoft/dotnet

WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY helloworld/*.csproj ./helloworld/
RUN dotnet restore

# copy everything else and build app
COPY helloworld/. ./helloworld/
WORKDIR /app/helloworld
RUN dotnet run
