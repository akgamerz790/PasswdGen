# PASSWDGEN

## Overview
PASSWDGEN is a simple password generation application written in C#. It allows users to create secure passwords based on specified criteria such as length and a customizable base keyword.

## Features
- Generate passwords with a minimum length of 10 characters.
- Customize passwords using a base keyword with random substitutions (e.g., `a` → `@`, `s` → `$`).
- Automatically appends random characters (letters, numbers, and special symbols) to meet the desired length.
- Ensures strong and secure password generation.

## How It Works
1. The user specifies the desired password length (minimum 10 characters).
2. The user can optionally provide a base keyword (default: `akgamerz_790`).
3. The program applies random substitutions to the base keyword:
   - `a` or `A` → `@`
   - `s` or `S` → `$`
4. Random characters (letters, numbers, and special symbols) are added to meet the desired password length.
5. The processed base keyword is inserted at a random position in the final password.

## Getting Started

### Prerequisites
- .NET SDK (version 6.0 or later)

### Building the Project
To build the project, navigate to the `PASSWDGEN` directory in your terminal and run the following command:

```bash
dotnet build
```

### Running the Application
To run the application, use the following command:

```bash
dotnet run
```

### Usage
Upon running the application, you will be prompted to enter the desired password length and select character types to include in the generated password. Follow the on-screen instructions to generate your password.

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.