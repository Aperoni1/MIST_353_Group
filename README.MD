Park Safety and Weather Information Web Application
Introduction

This project aims to provide users with essential safety and weather information related to parks. Whether users are planning a visit to a specific park or want to explore nearby options, this web application offers a convenient way to access crucial data. With a growing dataset and robust functionality, our goal is to ensure users can make informed decisions and stay safe during their outdoor adventures.
Project Overview

The web application currently consists of several key features:

    Park Weather: Users can obtain real-time weather information for a selected park by inputting its name.
    Park Status: This feature indicates whether a park is open based on active fire warnings.
    Future Enhancements: We are continuously expanding the dataset to include more parks and improving search functionalities for better user experience.

Carter Proctor’s Contribution

As part of this project, my contributions include the development of two Razor pages with C# code behind:

    ParkWeather: This page retrieves weather data for a specified park using the stored procedure CarterProctorSP2. Users can input the park's name to receive accurate weather updates.
    ParkStatus: This page determines the park's status (open or closed) based on active fire warnings, utilizing the stored procedure CarterProctorSP3.
    WeatherByLocationID (Future Feature): While not currently available upon launch, this page allows users to input a location ID number to retrieve weather information. Although functional, it's not included in the active web pages as of now.

Technical Details

The web application is built using Razor Pages with C# code behind for server-side processing. We utilize stored procedures to efficiently retrieve data from the database, ensuring fast and accurate results. Future development may include incorporating additional technologies or frameworks to enhance performance and user experience.
Future Features

    Integration of the WeatherByLocationID page to provide users with more flexibility in accessing weather data.
    Enhanced search functionality to allow users to find parks based on various criteria such as location, amenities, or safety ratings.
    Incorporation of user authentication and personalized features to tailor the experience to individual preferences.

Resources

    W3 Schools
    Class videos
    Chat GPT

Prompts

    Adding an Input Section: Add an <h1> tag saying "Find the weather for your park" and create a spot for the user to input the name of a park.

    Incorporating the API: Step-by-step instructions on incorporating your API.

    Dependency Between Projects: Determine if there is a need to create a dependency between the two projects.

    Error Correction: Review for general error correction and ensure proper formatting such as missing commas, etc.
