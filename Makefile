init-project:
	cd rent-car/src && dotnet dev-certs https --trust

launch:
	cd rent-car/src && dotnet run --launch-profile https