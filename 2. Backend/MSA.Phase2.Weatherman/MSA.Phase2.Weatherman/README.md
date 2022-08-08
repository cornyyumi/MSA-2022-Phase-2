# MSA-2022-Phase-2

## Phase 2 - Backend

### Weatherman Web API
This API will call the OpenWeatherAPI to get a response of the current weather at a City.\
It will also deserailize the Json response given by the OpenWeatherAPI and  it to save it to "WeatherDatabase.sqlite".\
The user can also call the API to process the weather data and be given a warning, if that are any concerns for the weather.

### Controller
The `WeathermanController.cs` implements the endpoints with the 4 CRUD operations for the API(GET, POST, PUT, DELETE)

- `GET /Weatherman/{city}`: Get the Json response of Weather information by entering a city name, Weather information is retrieved from database.
- `GET /Weatherman/temp/{city}`: Get a string of temperature warnings by enterting a city name, Weather information is retrieved from database.
- `GET /Weatherman/weather/{city}`: Get a string of temperature warnings by enterting a city name, Weather information is retrieved from database.

- `POST /Weatherman/add/{city}`: Post new Weather information by entering a city name. The Weatherman API will call the OpenWeatherAPI to find the data, and add it to the database.

- `PUT /Weatherman/update/{city}`: Update Weather information of a city by entering a city name.

   If the Weather information does not exist on the database, the Weatherman API will all the OpenWeatherAPI to find the data, and add it to the database.
   
- `Delete /Weatherman/delete/{city}`: Delete the existing Weather information from database by entering a city name.
### Configuration files
There are two configuration files for 'Production' and 'Development' environments.
Having mutiple confiuration files are useful as it can easily configure the settings of our environment.

When the application is ran in the `Production` environment, it will use the sqlite database 'WeatherDatabase.sqlite' to get, add, update, delete the data.

When the application is ran in the `Development` environment, it will use the in-memory database to to get, add, update, delete the data.\
This is espcially useful for the development stage as it has a faster access speed than a real database, and data stored in in-memory database will be reset each time the the application is started.

How to change configuration environment:
navigate to the 'MSA.Phase2.Weatherman' folder from terminal (eg `cd C:\Users\...\MSA.Phase2.Weatherman/`)
or
navigate to 'MSA.Phase2.Weatherman' folder and do 'Git bash here'
Then enter ''

### Section Two

Middleware 
* Demonstrate an understanding of how these middleware via DI (dependency injection) simplifies your code.

### Section Three

You will need to:

I have used NUnit code to unit test my code
* Demonstrate the use of NUnit to unit test your code.
* Use at least one substitute to test your code.
* Demonstrate an understanding of why the middleware libraries made your code easier to test.
