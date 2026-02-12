# FileHashSync

FileHashSync is a lightweight Windows application for **scanning folders, calculating file hashes, and comparing them using CSV snapshots**.

It helps you detect modified, missing, or new files and export only the files that have changed.

---

## Features

- Recursively scan directories
- Calculate MD5 hash for each file
- Export file hashes to CSV
- Load and compare against an existing CSV
- Visual comparison:
  - 🟢 Unchanged files
  - 🔴 Modified files
  - 🟡 Missing files
- Export only changed or missing files
- Uses relative paths for portability
- No database, no external dependencies

---

## How It Works

1. Select a directory
2. The app scans all files and calculates hashes
3. Export the result to a CSV file (snapshot)
4. Later, load the CSV and compare it with the current folder
5. Differences are highlighted and can be exported

---

## Use Cases

- Backup verification
- Folder synchronization
- File integrity checks
- Comparing file sets across machines
- Detecting unintended file changes

---

## Technology

- C# (.NET WinForms)
- MD5 hashing
- CSV-based snapshots
- Multithreaded scanning

---

## Security Notice

This project is open source and currently distributed unsigned.  
You are encouraged to review the source code or build the application yourself.

---

## Status

Active development.  
Feedback and contributions are welcome.
