#!/bin/sh
docker run --rm --volume "${PWD}:/local" --workdir /local openapitools/openapi-generator-cli $@
