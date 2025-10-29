# AI Agent Instructions for CourseWorkSanya

## Project Overview
This is a Windows Forms application for managing student academic records in a higher education context. It uses a singleton Dean pattern for data management and file-based storage.

## Core Architecture

### Data Model
- `Dean`: Singleton class managing all data collections
- Key entities:
  - `Student`: {key, fullname, recordbook, group}
  - `Lecturer`: {key, fullname, degree, experience}
  - `Theme`: {key, name, reporting}
  - `Statement`: {keyStudent, keyLecturer, keyTheme, date, grade}

### Data Flow
1. Data is loaded from text files in UTF-8 format
2. Dean singleton maintains in-memory collections
3. UI displays data in DataGridViews
4. Changes can be written back to files

### File Structure
Required text files (UTF-8 encoded):
- `студенты.txt` - Student records
- `преподаватели.txt` - Lecturer records
- `предметы.txt` - Subject/Theme records
- `ведомость.txt` - Statement/Grade records

## Key Patterns

### File Operations
- All files use semicolon (;) as delimiter
- Date format in files: "dd-MM-yyyy"
- Example student record: `key;fullname;recordbook;group`

### Data Management
```csharp
Dean dean = Dean.GetDean(); // Always get instance this way
dean.AddStudent(key, fullname, recordbook, group);
dean.AddLecturer(key, fullname, degree, experience);
// etc.
```

### UI Conventions
- DataGridView columns are customized after data binding
- First column (key) is typically hidden
- Headers are translated to Russian

## Common Tasks

### Adding New Records
1. Use dean.Add* methods for adding entities
2. Update relevant DataGridView
3. Enable the rewrite button
4. Call appropriate FileWrite_* method to persist

### Querying Data
Use LINQ for queries, following existing patterns:
```csharp
var query = from item in dean.items
            join related in dean.related on item.key equals related.key
            where item.property == value
            select new { /* projection */ };
```

## Project Setup and Running

### Prerequisites
1. Visual Studio with .NET Framework 4.7.2 support
2. Windows Forms development components installed

### Running the Project
1. Open `CourseWorkSanya.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Create four UTF-8 encoded text files in a directory:
   - `студенты.txt` - for student records
   - `преподаватели.txt` - for lecturer records
   - `предметы.txt` - for subject records
   - `ведомость.txt` - for grade statements
4. Run the application (F5 or Ctrl+F5)
5. In the application:
   - Enter the path to your data files directory in the text box
   - Click the "Download" button to load the data

### Sample Data Format
```
# студенты.txt (Students)
1;Иванов Иван Иванович;12345;ГР-12

# преподаватели.txt (Lecturers)
1;Петров Петр Петрович;к.т.н.;10

# предметы.txt (Subjects)
1;Математика;экзамен

# ведомость.txt (Statements)
1;1;1;29-10-2025;85
```

## Critical Notes
1. Always use `Dean.GetDean()` to access data - never create new instance
2. Handle file encoding (UTF-8) properly for Cyrillic text
3. Update UI after any data modifications
4. Enable rewrite button when data changes need persistence