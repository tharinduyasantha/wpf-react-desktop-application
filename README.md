# WPF-React Desktop Application

This project includes a WPF application and a React application designed to demonstrate integration between a modern web front-end (React) and a traditional desktop application framework (WPF).

## Prerequisites

Before you begin, ensure you have installed:

- [Node.js and npm](https://nodejs.org/en/download/) - This is necessary for running the React application.
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) - Ensure you have the .NET desktop development workload installed for WPF application development.

## Setting Up the React Application

To get the React application running:

1. Navigate to the `React Application` directory from the root of the repository:

    ```bash
    cd React Application
    ```

2. Install the required npm packages:

    ```bash
    npm install
    ```

3. Start the application:

    ```bash
    npm start
    ```

   The React application will be available at `http://localhost:3000`.

## Setting Up the WPF Application

To set up and run the WPF application:

1. Open the solution file `WPF Application/WPFCompact.sln` in Visual Studio.

2. Install the necessary NuGet packages, if they are not restored automatically:

    - `Microsoft.Web.WebView2` (From NuGet packages)
    - `WPF-UI` (from Extentions)

3. Build the solution by selecting `Build -> Build Solution` from the menu or pressing `Ctrl+Shift+B`.

4. Run the application by selecting `Debug -> Start Debugging` from the menu or pressing `F5`.

   Make sure the React application is running, as the WPF application will need to interact with it.
