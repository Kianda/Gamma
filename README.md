# Gamma
ASP.NET Web API example with MySQL database connection and simple html client for API consume

#### Database Connection
For testing purposes there is already a MySQL available at 89.36.210.40:3316 with username root, password root and database name 'gamma' (you can connect to it with any client)

Or you can run your own with docker (for example):
docker run --name temp-mysql -e MYSQL_ROOT_PASSWORD=root -p 3316:3306 -d mysql:5.6 (or any other tag)
Then edit the credentials in appsettings.json file in visualstudio (and rebuild).

#### ASP.NET Api
For testing purposes there is already a container running at 89.36.210.40:8085 (it's currently connected to 89.36.210.40:3316 mysql).

Or you can run the project from visualstudio and test it locally (http://localhost:5000)
Remember to change the api url at the beginning of the html client file


#### Api Methods
api/user (get: list of all users from the 'user' table)
api/user/{guid} (get: the user corresponding to the guid parameter)


#### Try
Just curl the API:
curl http://89.36.210.40:8085/api/user
or use the html client provided


#### Additional docker info
To build your custom image run the following command in the root of the project:
docker build --no-cache -t yourusername/gamma:latest .

To push it in your registry (docker hub in this example):
docker push yourusername/gamma:latest

To run it in your environment:
docker run -d -p 8085:80 --name gamma yourusername/gamma:latest

