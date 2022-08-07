# MSA-2022-Phase-2

## Phase 2 Requirements - Backend

### Weatherman Web API
This API will call the OpenWeatherAPI to get a response of the current weather at a City.\
It will also deserailize the Json response given by the OpenWeatherAPI and  it to save it to "WeatherDatabase.sqlite".\
The user can also call the API to process the weather data and be given a warning, if that are any concerns for the weather.

The `WeathermanController.cs` implements the endpoints with the 4 CRUD operations for the API(GET, POST, PUT, DELETE)

- `GET`: Get the Json response of Weather information by entering a city name, from the database.

- `Post`: Post new Weather information by entering a city name. The Weatherman API will call the OpenWeatherAPI to find the data, and add it to the database.

- `Put`: Update Weather information of a city by entering a city name.

   If the Weather information does not exist on the database, the Weatherman API will all the OpenWeatherAPI to find the data, and add it to the database.
   
- `Delete`: Delete the existing Weather information from database .

* Create at least two configuration files, and demonstrate the differences between starting the project with one file over another.

### Section Two

Middleware 
* Demonstrate an understanding of how these middleware via DI (dependency injection) simplifies your code.

### Section Three

You will need to:

* Demonstrate the use of NUnit to unit test your code.
* Use at least one substitute to test your code.
* Demonstrate an understanding of why the middleware libraries made your code easier to test.
