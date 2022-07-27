DOCKER_IMAGE="openapitools/openapi-generator-cli"
PACKAGE_NAME="nomad-dotnet"

src tests: openapi.yaml templates
	@echo "==> Building OpenAPI client..."
	docker run \
		--rm \
		--volume "$(PWD):/local" \
		--workdir "/local" \
		 $(DOCKER_IMAGE) generate -i openapi.yaml --config config.json -t templates

clean:
	rm -rf docs src .gitignore appveyor.yml git_push.sh *.sln

templates:
	docker run \
		--rm \
		--volume "$(PWD):/local" \
		--workdir "/local" \
		 $(DOCKER_IMAGE) author template -g csharp-netcore -o templates
