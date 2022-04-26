# Shell Scripting 
- Examples of Shells - Bourne Shell, C-Shell, Powershell etc...
- What is Shell? 
    - A computer program which is a command line interpreter (not compiled).
    - A shell script includes operations to be performed like file manipulation, program execution and printing text.
- A shell file has an extension .sh
- sh - Bourne shell which was used for Unix
- BASH - Bourne Again Shell
- check your bash location : `which bash`,  outputs to `/usr/bin/bash`

## Basic Commands in Shell
- `cd` -> change directory
    - `cd c:\Revature\MyRepo`
    - if your folder has space in between the use the path within quotes
        - `cd "c:\Revature\My Repo"`
- `mkdir` - make a new directory
- `rmdir` - remove a directory
- `touch` - command to create a new file
- `clear` - to clear the screen
- `echo` - to output a string
- `ls` -  to list output files in the current directory
- `ls -l` -  to list output files in the current directory in long listing format.
    - Format includes file type, file permissions, number of hard links to the file, file owner, file soze, file group, date and time, file name
    - file permissions include 
        - `r` - Permission to read the file
        - `w` - Permission to write the file
        - `x` - Permission to execute the file
        - Ex `rw-r--r--` means that user can read and write the file and the group and others can only read the file.
- `ls -la` - long listed format of the file including hidden files

### Cat
- Cat mean 'concatenate'
- Command is used to view, create and append files in linux.
- `cat Activity.md` - will display the contents of the file
- `cat Activity.md gitNotes.md` - will read the contents of multiple files one after another
- `cat -e Activity.md gitNotes.md` - will read the contents of multiple files one after another with a separator **$**, which will be inserted at the end of the contents.
- `cat >ShellCommands.md` - create a new file with cat command and when you press `<enter>` it will prompt to add some text, press `<ctrl> + d ` to save the newly created file.
- `cat -n Activity.md` - display the line numbers along with the contents of the file
- `cat ShellScripting.md >> Activity.md` - Append the contents of *ShellScripting.md* to *Activity.md*

### Grep
- It is an essential Linux and Unix command to search text and strings in a given file
- `grep 'git' filename`  - this will search lines that contains the word *git* in the filename, **case sensitive**.
- `grep -i 'git' filename`  - this will search lines that contains the word *git* in the filename, **case insensitive**.
- `grep -R 'git'` - looks for all the files in the current directories and all of its sub-directories in linux for the word *git*, included hidden directories as well.
- `grep -c 'git' filename` - search and display the total number of times that the string 'git' appears in a filename.


## References 
1. https://bash.cyberciti.biz/guide/Main_Page
2. https://www.tutorialspoint.com/unix/shell_scripting.htm
3. If you are video person : https://www.youtube.com/playlist?list=PLS1QulWo1RIYmaxcEqw5JhK3b-6rgdWO_