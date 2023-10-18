DOCKER_IMAGE="openapitools/openapi-generator-cli:v7.0.1"
PACKAGE_NAME="nomad-dotnet"

src tests: openapi.yaml
	@echo "==> Building OpenAPI client..."
	docker run \
		--rm \
		--volume "$(PWD):/local" \
		--workdir "/local" \
		 $(DOCKER_IMAGE) generate -i openapi.yaml --config config.json

clean:
	rm -rf docs src .gitignore appveyor.yml git_push.sh *.sln
