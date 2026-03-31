
SHELL = /bin/bash

REPORTS_DIR ?= .reports
ARTIFACTS_DIR ?= artifacts
CONFIGURATION ?= Release

# Overridable by CI
COMMIT_SHORT     ?= $(shell git rev-parse --verify --short HEAD)
VERSION_NOPREFIX ?= "0.0.0-sha.$(COMMIT_SHORT)"
VERSION          ?= "v$(VERSION_NOPREFIX)"
PACKAGE_VERSION  ?= $(VERSION_NOPREFIX)

.PHONY: prepare
prepare:
	dotnet restore saltoapis-dotnet.sln

.PHONY: sanity-check
sanity-check:

.PHONY: build
build:
	dotnet build saltoapis-dotnet.sln -c $(CONFIGURATION) --no-restore

.PHONY: test
test:
	dotnet test saltoapis-dotnet.sln -c $(CONFIGURATION) --no-build

.PHONY: release
release:
	dotnet pack saltoapis-dotnet.sln -c $(CONFIGURATION) --no-build -o "$(ARTIFACTS_DIR)/nuget" /p:PackageVersion=$(PACKAGE_VERSION)
	@if [ -n "$$NUGET_API_KEY" ]; then \
		dotnet nuget push "$(ARTIFACTS_DIR)/nuget/*.nupkg" --skip-duplicate -k $$NUGET_API_KEY -s https://api.nuget.org/v3/index.json; \
		dotnet nuget push "$(ARTIFACTS_DIR)/nuget/*.snupkg" --skip-duplicate -k $$NUGET_API_KEY -s https://api.nuget.org/v3/index.json; \
	fi

.PHONY: clean
clean:
	dotnet clean saltoapis-dotnet.sln -c $(CONFIGURATION)
	rm -rf "$(ARTIFACTS_DIR)"
