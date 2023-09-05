# Api Versioning in .Net 6

ApiVersioning makes it possible for our clients to choose whether they would like to use old or updated version of api, so we can define version in following three ways:

    1) **UrlSegmentApiVersionReader** – this method allow us to get the version number from the URL, ex: https://domain.com/api/v1/metod
    2) **HeaderApiVersionReader** – makes it possible to get the version number from a header parameter, ex: x-api-version:1.0
    3) **MediaTypeApiVersionReader** – gives us the option to get the parameter from the header again, but this time it’s placed within the Content-Type or Accept flags, ex: 
                                  Accept/Content-Type: application/json; x-api-version=1.0


**Also I have covered multiple version with swagger.**
