SHELL = bash

PGPORT     ?= 5432
PGHOST     ?= localhost
PGUSER     ?= postgres
PGDATABASE ?= dev-db
PGPASSWORD ?= postgres
PGIMAGE    ?= postgres:latest

.EXPORT_ALL_VARIABLES:
.PHONY: test build

up:
	cd SQL && docker-compose up -d

down:
	cd SQL && docker-compose down

publish:
	cd ./SQL/WebApplication.EFCore && dotnet publish && cd ../Database.EFCore && dotnet publish

unlock-pgdata:
	cd SQL && sudo chmod a+rwx pgdata && sudo chown -R root:${USER} pgdata
