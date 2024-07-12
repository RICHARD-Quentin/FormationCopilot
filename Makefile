init-project:
	cd rent-car/src && dotnet dev-certs https --trust

launch:
	cd rent-car/src && dotnet run --launch-profile https

launch-utils:
	cd utilities && dotnet run

launch-db:
	docker run --rm --name database -e MYSQL_ROOT_PASSWORD=my-secret-pw -p 3306:3306 -d mysql:latest
