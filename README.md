# CourseWorkSanya

Small Windows Forms application to manage student records (students, lecturers, subjects, and grade statements). The app uses a singleton `Dean` class to hold in-memory lists and reads/writes data from plain UTF-8 text files.

## Quick Start (Windows / Visual Studio)

Requirements
- Visual Studio with .NET Framework 4.7.2
- Windows Forms workload/components installed

Run with Visual Studio
1. Open `CourseWorkSanya.sln` in Visual Studio.
2. Build the solution (Ctrl+Shift+B).
3. Run the app (F5 or Ctrl+F5).
4. Create a directory for data files (UTF-8 encoded) and place the four required files there (see "Data files" below).
5. In the running application, enter the path to that directory in the text box and click "Download".

Run from command line (optional)
- From a Developer Command Prompt for Visual Studio (or any shell where `msbuild` is available):

```powershell
msbuild .\CourseWorkSanya.sln /p:Configuration=Debug
Start-Process -FilePath .\bin\Debug\CourseWorkSanya.exe
```

or directly run the built exe:

```powershell
& .\bin\Debug\CourseWorkSanya.exe
```

## Data files (required)
Create four semicolon-delimited UTF-8 text files. Date format: `dd-MM-yyyy`.

- `студенты.txt` (students)
  Format: `id;fullname;recordbook;group`
  Example:
  `1;Иванов Иван Иванович;12345;ГР-12`

- `преподаватели.txt` (lecturers)
  Format: `id;fullname;degree;experience`
  Example:
  `1;Петров Петр Петрович;к.т.н.;10`

- `предметы.txt` (subjects/themes)
  Format: `id;name;reporting`
  Example:
  `1;Математика;экзамен`

- `ведомость.txt` (statements/grades)
  Format: `studentId;lecturerId;themeId;date;grade`
  Example:
  `1;1;1;29-10-2025;85`

Notes
- Files must be UTF-8 encoded because the UI and files contain Cyrillic text.
- The code expects semicolon (`;`) separators and exact column ordering shown above.

## Key implementation notes for contributors
- Data is held in a singleton `Dean` (see `Program.cs` for model classes and `Dean.GetDean()` usage).
- Add records via `dean.AddStudent(...)`, `dean.AddLecturer(...)`, etc.
- UI binds `dean.students`, `dean.lecturers`, `dean.themes`, and `dean.statement` to `DataGridView`s in `Form1.cs`.
- After modifying in-memory lists, enable the rewrite button in UI or call `Program.FileWrite_Student(...)` (file write helpers are implemented for students — other write helpers are minimal/absent; inspect `Program.cs`).

## Project structure (relevant files)
- `Form1.cs` / `Form1.Designer.cs` — UI and event handlers.
- `Program.cs` — model classes (`Student`, `Lecturer`, `Theme`, `Statement`), `Dean` singleton, and file read/write helpers.
- `CourseWorkSanya.sln`, `CourseWorkSanya.csproj` — solution/project files.
- `.github/copilot-instructions.md` — AI helper guidance (kept in sync with this README).

## Troubleshooting
- If data won't load, verify the path entered in the app and that files exist with correct names and UTF-8 encoding.
- If the app crashes on parsing, check the file line formats (missing fields or wrong separators are common causes).

## Next steps for maintainers
- Consider adding file write functions for lecturers/themes/statements for full persistence symmetry (currently only `FileWrite_Student` is implemented).
- Add unit tests for file parsing and LINQ queries.

If you'd like, I can also create sample data files in the repo (as `.sample` files) or add a small script to validate input files before loading.
