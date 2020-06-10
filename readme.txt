A dockerized client-side blazorapp that enables CRUD operations on Speakerdata.
3 containers are involved:
	Container 1:ASP.NET API
	Container 2:Database (SQL Server)
	Container 3:Blazor
To run the applicationpg:
simply runs “docker-compose up” and views the web page 
by going to http://localhost:8888

Built by:
Wei-Han Chou
Lawrence Zheng


Major challenges:
Putting our app into docker containers

Please clean up docker images and browser cookies and history before docker compose - up.