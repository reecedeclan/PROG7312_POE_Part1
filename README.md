# eCitizen Municipal Services Portal

## Description
The **eCitizen Municipal Services Portal** is a C# Windows Forms Application designed to streamline municipal services. It allows residents to report issues, view logged issues, and engage in community discussions. This portal aims to:

- Provide transparency in municipal services
- Improve communication between residents and local authorities
- Enhance user engagement through community forums

---

## Features

- **Report Issues**:  
  Users can report issues related to sanitation, roads, utilities, and more. Each report can include up to 5 media files (images or documents). A progress bar helps users track the submission process.

- **View Logged Issues**:  
  Users can view their submitted issues in a data grid format, displaying details such as location, category, and description.

- **Community Forums**:  
  A platform for residents to engage in discussions about municipal services (e.g., road maintenance, billing issues).

- **Reply to Discussions**:  
  Users can reply to discussions in the community forum.

### Disabled Features (Future Updates):
- **Local Events and Announcements**: Upcoming feature to display municipal events.
- **Service Request Status Tracking**: Allows residents to track the status of their submitted service requests.

---

## How to Run

1. Clone the repository to your local machine.
2. Open the project in **Visual Studio**.
3. Build the solution and ensure all dependencies are installed.
4. Run the application.

---

## Components

- **Form1**: Main menu with options to report issues, view logged issues, and open community forums.
- **Report_Issues**: Form to report municipal issues, attach media files, and track completion via a progress bar.
- **ViewIssues**: Displays logged issues in a data grid.
- **CommunityForums**: Displays ongoing discussions and allows users to post new topics.
- **DiscussionReply**: Enables users to reply to forum discussions.
- **GlobalData**: Stores globally accessible data like the list of reported issues.
- **Issue Class**: Represents an issue with properties like location, category, description, and media attachments.

---

## Usage Instructions

### Reporting an Issue
1. Click on "**Report an Issue**".
2. Enter the location, select a category, and provide a description.
3. Attach up to 5 media files (if applicable).
4. Submit the issue. The system will confirm submission details.

### Viewing Logged Issues
- Click on "**View Logged Issues**" to see previously reported issues.

### Community Forums
- Open "**Community Forums**" to view and engage in discussions.
- To start a new discussion, type your message in the text box and click "**Post**".
- Reply to existing discussions using the reply functionality.

---

## Future Updates

- **Local Events and Announcements**:  
  Will provide information about local municipal events.
  
- **Service Request Status**:  
  Will allow users to track the status of their submitted service requests.

---

## Author

This project was developed by **Reece Declan Cunningham (ST10043367)** as part of the **PROG7312 Portfolio of Evidence**.

---

## Contact

For any queries or issues regarding the application, please contact the developer at:  
**Email**: [st10043367@vcconnect.edu.za](mailto:st10043367@vcconnect.edu.za)
