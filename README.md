# How to Get Started with the Syncfusion Blazor Mention Component

## Overview

This sample demonstrates how to integrate and configure the Syncfusion [Blazor Mention](https://www.syncfusion.com/blazor-components/blazor-mention) component in a Blazor WebAssembly application. The application provides an interactive mention experience that displays suggestion items when a configured trigger character is entered in a target editable element. The sample showcases common Mention component customizations, including popup configuration, filtering behavior, sorting, and suffix text support. It serves as a starting point for building tagging, collaboration, commenting, and social-style text entry experiences in Blazor applications.

## Key Features

- Demonstrates the Syncfusion Blazor Mention component integrated with a Syncfusion Rich Text Editor.
- Associates the Mention component with the Rich Text Editor content area using the `Target` property.
- Uses a strongly typed `UserData` model as the Mention data source.
- Displays mention suggestions from a predefined collection of user names and email addresses.
- Configures a custom mention trigger character using `MentionChar="#"`.
- Displays the mention trigger character in selected values using `ShowMentionChar="true"`.
- Supports multi-word mention values using `AllowSpaces="true"`.
- Appends custom text after item selection using `SuffixText=" Welcome!"`.
- Customizes the suggestion popup using `PopupHeight="200px"` and `PopupWidth="250px"`.
- Sorts suggestion items in ascending order using `SortOrder="SortOrder.Ascending"`.
- Filters suggestion items using the `FilterType.EndsWith` filter mode.
- Maps display values through `MentionFieldSettings` with the `Text="Name"` field configuration.
- Uses the Syncfusion Rich Text Editor as the editable input surface for mention insertion.
- Includes a sample weather forecast page that demonstrates HTTP-based JSON data retrieval using `HttpClient`.
- Loads data from `wwwroot/sample-data/weather.json` using `GetFromJsonAsync<T>()`.
- Displays weather forecast records in a tabular format with dynamically calculated Fahrenheit values.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the `BlazorApp__Mention.csproj` project file in Visual Studio 2022.
3. Restore NuGet packages when prompted.
4. Build the application.
5. Run the project using `Ctrl+F5`.

**Visual Studio Code**

1. Clone or download this repository.
2. Open the repository folder in Visual Studio Code.
3. Open a terminal and navigate to the project directory.
4. Restore NuGet packages:

```bash
dotnet restore
```

5. Run the application:

```bash
dotnet run
```

6. Open the local application URL displayed in the terminal after the application starts.

## Project Structure

`Pages/Index.razor` - Main sample page demonstrating the Syncfusion Mention component integrated with `SfRichTextEditor`, including custom trigger character, popup customization, filtering, sorting, suffix text, and user data binding.

`Pages/FetchData.razor` - Sample page that retrieves weather forecast data from a local JSON file using `HttpClient` and displays the results in a table.

`Shared/SurveyPrompt.razor` - Default Blazor template component included in the application.

`wwwroot/sample-data/weather.json` - Local JSON data source consumed by `Pages/FetchData.razor`.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation: https://blazor.syncfusion.com/documentation/mention/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.