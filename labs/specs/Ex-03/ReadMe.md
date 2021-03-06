# Train Watch - Ex03 - Web Client (Front-End) Setup and Form Input via the Contact Page

> This is the **first** in a series of exercises where you will be building a website to manage information on trains. **Train Watch** is a community site for train lovers who want to keep up-to-date on trains across North America. They want to maintain a database of Engines and RailCars.
>
> **This set is cumulative**; future exercises in this series will build upon previous exercises.

## Overview

You are to create a new ASP.NET Core Web Application (Razor Pages) for this exercise.

Use the demos presented in class as a guide to implementing this exercise.

```csharp
# From the src/ folder
# Create a Razor Pages Web Application which will be the Front-End
dotnet new webapp -n TrainWatch -o TrainWatch.Web
```
To ensure that your web application works, build and run your project.

```csharp
# From the src/ folder
cd TrainWatch.Web
dotnet build
dotnet watch run
```

A browser window should open (https://localhost:5001). If you get a certificate error, you need to create a self-signed certificate for your developer machine by typing the following (read more on this [Microsoft Docs page](https://docs.microsoft.com/aspnet/core/security/enforcing-ssl#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos)).

```csharp
dotnet dev-certs https --trust
```

### Modify `Index.cshtml`

Modify the home page to include the following.

- The title of the site (**Train Watch**)
- A simple logo for the site. Create an `images` folder in `wwwroot` and store the image there. Get an image from the web as a jpg or png.
- One paragraph welcome and summary description of the site.

### Update the `_Layout.cshtml`

Ensure that the menu navigation has the following items.

- A link to the home page (`/Index`) with the text "Home"
- A link to the contact page (`/Contact`) with the text "Contact"
- A link to the privacy page (`/Privacy`) with the text "Privacy"

### Add `Contact` Page

Create an `Contact.cshtml`/`Contact.cshtml.cs` Razor Page.

```csharp
# From the src/ folder
cd TrainWatch.Web
dotnet new page -n Contact -o Pages
```
To ensure that your web application works, build and run your project.

```csharp
# From the src/ folder
cd TrainWatch.Web
dotnet build
dotnet watch run
```

In Contact.cshtml add a "Contact Us" page with a form (`method="POST"`) to allow people to send a message to us. The form must include the following (all fields are required).

- **Message Title** (use `<input type="text">`)
- **User Email** (use `<input type="email">`)
- **Subject** (use a `<select>` element with the options of "Contributing", "Request Membership", "Bug Report")
- **Message Body** (use a `<textarea>` element)
- **Active Member** (use a `<input type="checkbox">`)
- **Submit** button (use a `<button type="submit">Submit</button>` element)

In the Contact.cshtml.cs file add C# code in the methods OnGet(), and OnPost(), to process the form's input by echoing back all of the data entered by the user in a "SuccessMessage".

To ensure that your web application works, build and run your project.

```csharp
# From the src/ folder
cd TrainWatch.Web
dotnet build
dotnet watch run
```