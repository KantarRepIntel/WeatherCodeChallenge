# Weather Code challenge

We need to create a solution to determine if a city is having **good weather** or **bad weather**, but if is it bad weather also we need to get details of that. For example, if we want to look at the weather of Barcelona city (guess that now is raining in Barcelona) we should expect something like this output "In Barcelona is having bad weather because is raining". This kind of thing should be clearly defined by the candidate and should be reflected in the tests **OpenWeatherMapClientTests** (that is also incompleted).

To do that we have access to an open weather map API to make a request and take the parameters (aka sensors) of the weather.

The solution has an incomplete service WeatherDetectorService, that taking sensors should determine if is having good weather and also if it is bad weather including the detailed reason.

As part of the code challenge, we want to store this on a repository (preferably in Entity Framework Core, using an in-memory option database will be enough).

We have an incompleted solution and the candidate should finish and connect the incompleted parts. Taking into account:

1. Define the properties that model Weather needs to store all the data.
2. Implement interface IWeatherClient to make the calls to OpenWeatherMap API
3. Implement interface IWeatherRepository to store the defined model Weather
4. Complete the endpoints GET and POST from WeatherController

Weather API [OpenWeatherMap.org](https://openweathermap.org/current)

||  	Example api call to obtain weather from Barcelona 	|
|---	|---	|
| HTTP GET Request 	| <a href="https://api.openweathermap.org/data/2.5/weather?q=barcelona&units=metric&APPID=1b9c96d2448f9204d210ddd5ac192dc1" target="_blank">https://api.openweathermap.org/data/2.5/weather?q=barcelona&units=metric&APPID=1b9c96d2448f9204d210ddd5ac192dc1</a>	|
| Response 	| <pre>{ <br>   "coord": { ... }, <br>   "weather": [{ <br>         "id": 801, <br>         "main": "Clouds", <br>         "description": "few clouds", <br>         "icon": "02d" <br>      }], <br>   "base": "stations", <br>   "main": { ... }, <br>   "visibility": 10000, <br>   "wind": { ... }, <br>   "clouds": { ... }, <br>   "dt": 1618228232, <br>   "sys": { ... }, <br>   "timezone": 7200, <br>   "id": 3128760, <br>   "name": "Barcelona", <br>   "cod": 200 <br>}</pre> 	|

## Goals to evaluate

- How the candidate focus the solution

- How you approach the project (we left some stuff intentionally open, so you have to evaluate trade-offs and make some decisions)

- Design and architecture
- How the code is writed
- Solution testing

**Please do not hesitate to contact marcal.albert@kantar.com if any doubt**
