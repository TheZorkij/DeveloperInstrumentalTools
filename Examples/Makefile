SHELL = bash

PGPORT     ?= 5445
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

unlock-pgdata:
	cd SQL && sudo chmod a+rwx pgdata && sudo chown -R root:${USER} pgdata
