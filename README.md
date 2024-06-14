# Contacts Manager

## Overview
The Contacts Manager is a simple console application written in C# that allows users to manage their contacts. It provides functionalities such as adding new contacts, removing existing contacts, viewing all contacts, and searching for specific contacts.

## Getting Started
To run the Contacts Manager program, ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine. Follow the steps below to get started:

1. Clone this repository to your local machine using `git clone https://github.com/your-repository-url.git`.
2. Navigate to the project directory in your terminal or command prompt.
3. Run the command `dotnet run` to start the program.

## Usage
Upon running the program, you'll be presented with a menu where you can choose from the following options:

- **Add contact:** Allows you to add a new contact to the manager.
- **Remove contact:** Enables you to remove an existing contact.
- **View all contacts:** Displays a list of all contacts currently stored.
- **Search contact:** Lets you search for a specific contact by name.

Follow the on-screen instructions to perform the desired actions for each menu option.

### Adding a Contact
To add a contact, follow these steps:

1. Select the "Add contact" option from the main menu.
2. Enter the name and number of the contact when prompted.
   - Ensure that the name is at least 2 characters long and the number is a 10-digit valid number.
3. The program will confirm if the contact was added successfully or if it already exists in the manager.

### Removing a Contact
To remove a contact, follow these steps:

1. Choose the "Remove contact" option from the main menu.
2. Enter the name of the contact you want to remove.
3. The program will notify you if the contact was successfully removed or if it does not exist in the manager.

### Viewing All Contacts
To view all contacts stored in the manager, select the "View all contacts" option from the main menu. If you have contacts, their names and numbers will be displayed. Otherwise, you'll be informed that you don't have any contacts yet.

### Searching for a Contact
To search for a specific contact, follow these steps:

1. Select the "Search contact" option from the main menu.
2. Enter the name of the contact you want to search for.
3. If the contact exists in your list, the program will display their name and number. Otherwise, you'll receive a message indicating that the contact was not found.

### Exiting the Program
To exit the program, choose any option from the menu and enter "no" when asked if you would like to perform another service.

## Example
Here's an example of how you might interact with the Contacts Manager:

1. Add a contact named "John Doe" with the number "1234567890."
2. View all contacts to confirm "John Doe" is added.
3. Search for "John Doe" to display his details.
4. Remove "John Doe" from your contacts.
5. Exit the program.

## Contributing
Contributions to the Contacts Manager project are welcome! If you have ideas for additional features or improvements, please fork this repository and submit a pull request with your changes.

