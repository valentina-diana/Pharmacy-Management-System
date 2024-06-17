# Pharmacy Management Application

## Introduction

This project focuses on developing an object-oriented application for pharmacy management. The application allows for the administration of medicines, clients, and sales, facilitating daily operations within a pharmacy.

## Objectives

- **User Authentication:** Secure access to the application.
- **Medicine Management:** Adding, modifying, searching, and deleting medicines from the database.
- **Client Management:** Adding, modifying, searching, and deleting clients.
- **Sales Management:** Recording and managing sales.
- **Adding New Users:** Managing users who have access to the application.

## Database Structure

The application's database includes the following tables:

- Authentication
- Medicine
- Client
- Sale

## Key Features

1. **Authentication**
   - The login page includes two labels and two textboxes for entering the username and password, a login button, a label to reset fields, and a picturebox to close the application.
   - The login button code verifies the correctness of entered data and displays a message in case of incorrect credentials.

2. **Home Page**
   - Contains six pictureboxes for navigating between application pages and a logout button.

3. **Medicine Management**
   - The Medicine page allows adding, modifying, deleting, and searching for medicines. Data is displayed in a DataGridView.
   - The add button code registers a medicine in the database and displays it in the DataGridView.
   - The modify and delete button code allows updating and deleting records.
   - PDF Export: Option for printing medicine data.
   - The medicine search page allows searching by name and displays results in a DataGridView.

4. **Client Management**
   - Works similarly to Medicine Management but handles client data.

5. **Sales Management**
   - The Sales page allows adding, modifying, and deleting sales records, as well as viewing a sales chart.

6. **Adding Users**
   - The Add Users page allows registering new users in the database.

## Frameworks and Technologies Used

- **System.Data.SqlClient:** for connecting to and manipulating the database.
- **C# and Windows Forms:** for developing the application's user interface.

## Conclusion

This project is a comprehensive application for pharmacy management, offering essential functionalities for efficient management of medicines, clients, and sales. By utilizing modern technologies and an object-oriented design, the application ensures an intuitive interface and robust functionalities for users.
