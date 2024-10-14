**Python**
py/PYTHON filename
Create excecutable file cd-C:\Users\YourName\Documents>pyinstaller --onefile my_script.py

**C/C++**
gcc/g++ filename -o 'compiled_filename' 
Run executable file- 'filename or ./filename
clang -o simple.c simple

**C#**
1.Navigate to your project directory:
2. type -'dotnet new console -n MyApp
2.2 cd MyApp''
3. Replace the generated Program.cs with your code or add your code directly.
4.run application 'dotnet run'

Run a Specific C# File Directly (Without Creating a Project): If you just have a single C# file and want to run it directly without setting up a full project, you can use:
5.dotnet script yourfile.csx
DOTNET-SCRIPT IS A SEPARATE TOOL THAT ALLOWS RUNNING C# SCRIPTS. YOU CAN INSTALL IT WITH:
-dotnet tool install -g dotnet-script

**Rust**
1. Method One
rustc 'filename'
Run executable file- 'filename' or .\'filename'

2. Method two
Type - cargo new 'filename'
Navigate to the project directory: cd 'filename'
Replace the contents of src/main.rs with the desisred code
Build and run the project: cargo run

**Java**
** File name must be same as Public Class name
1. Javac 'Public class name'.java
2. java  'Public class name'

