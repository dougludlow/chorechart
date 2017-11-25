start : clean restore build run 

all : clean restore build

clean :
	dotnet clean src/ChoreChart.Api/ChoreChart.Api.csproj

restore :
	dotnet restore src/ChoreChart.Api/ChoreChart.Api.csproj

build :
	dotnet build src/ChoreChart.Api/ChoreChart.Api.csproj

run :
	cd src/ChoreChart.Api && dotnet watch run -p ChoreChart.Api.csproj