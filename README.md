# SwaggerNetCore
Test de Swagger com netcore docker e heroku

publishing to heroku:

- docker login
- heroku login
- docker build - swaggernetcore .
- docker tag swaggernetcore registry.heroku.com/swaggernetcore/web
- docker push registry.heroku.com/swaggernetcore/web
- heroku stack:set container -a swaggernetcore
- heroku container:login
- heroku container:release -a swaggernetcore
