# Components.Advanced app developed with Blazor

Test advanced components in blazor

## dotnet version:

6.0.400

## Project created with:

dotnet new blazorwasm -o Components.Advanced --hosted

## To develop the project:

dotnet watch --project Server

## Testing

- Templated Component
  - Grid Component created: Client.Shared.Grid
  - ListView Component created: Client.Shared.ListView
  - ListViewWigPig Component for test RenderFragment&lt;RenderFragment&gt;: Client.Shared.ListViewWigPig
- Blazor Error Boundaries: In FetchData.razor with forecast.TemperatureF
