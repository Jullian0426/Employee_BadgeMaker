# CatWorx.BadgeMaker

CatWorx.BadgeMaker is a C# console application that creates custom badge images for employees. The application can either use employee data entered manually by the user, or it can fetch random employee data from the Random User API (https://randomuser.me/).

The application prints out the fetched data, creates a CSV file of the data, and generates badge images using an image template, storing them in a local directory.

## Classes

The application consists of four classes:

1. **Program**: This is the main class and entry point of the application. It's responsible for orchestrating the other classes to perform the tasks needed.

2. **Util**: This class houses all utility functions such as fetching employee data (either manually or from the API), printing employee data, writing the data to a CSV file, and generating the badge images.

3. **Employee**: Represents an employee with fields for first name, last name, ID, and photo URL. It also provides methods to access these fields.

4. **PeopleFetcher**: Responsible for gathering employee data. It can either prompt the user to enter data manually, or fetch data from the Random User API.

## How to Use

To run the program, follow these steps:

1. Open a terminal or command prompt.
2. Navigate to the directory where the `CatWorx.BadgeMaker` project is located.
3. Run the program using the `dotnet run` command.
4. You will be prompted with "Fetch data from API?". If you want to use data from the API, type `yes`. If you want to manually enter the data, type `no`.
5. If you chose to manually enter data, you will be prompted to enter the first name, last name, ID, and photo URL of an employee. After entering the data for an employee, you will be prompted for the first name of the next employee. If you want to stop entering data, just press Enter without typing anything.
6. The application will print out the fetched data, create a CSV file in a 'data' folder, and generate the badge images, saving them in the same 'data' folder.

## Dependencies

- **SkiaSharp**: This library is used to manipulate the image data when creating the badges. This includes positioning and scaling the employee's photo, adding the employee's name and ID, and saving the final image.

- **Newtonsoft.Json**: Used to parse the JSON data returned by the Random User API.

## Notes

This application does not handle errors that may occur if, for example, the Random User API is down or if invalid data is entered manually. It is intended as a simple demonstration of interacting with APIs, processing data, and working with images and files in C#.