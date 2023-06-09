This is a note for my .NET lecture from this VDO: https://www.youtube.com/watch?v=9zJn3a7L1uE

# Notes
The WeatherForecastController.cs creates a controller route which is determined by this class 'WeatherForecastController'. It creates /weatherforecast route (Note that the route is not case sensitive when requesting. That means that /weatherFORECAST also works).

This lecture follows MVC pattern.
- Model: An object that represent something
- View: How the user view the model (as a text, 3D model, UI, etc.). Each changes in the model is reflected by the view.
- Controller: Creates a model

## Web API Structure
- Client <=> Controller <=> Service <==> Database
- DTO goes between client, controller, and service
- Model goes into the database