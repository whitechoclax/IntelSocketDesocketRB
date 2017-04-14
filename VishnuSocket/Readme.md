Note if performing a clean install you will need to download extra files to allow you to run in visual studio.

Goto to [sourceforge.net/projects/emgucv/files/emgucv/3.0.0/](https://sourceforge.net/projects/emgucv/files/emgucv/3.0.0/libemgucv-windows-universal-3.0.0.2157.exe/download)

1. Run the exe file you downloaded  
2. Navigate to the folder you just installed/downloaded, find the bin folder  
3. Copy the x64 and x86 folders right at the top  
4. Paste them into the output directory (**vishnusocket/vishnumain/bin/x64/debug**)
   * Note If you see only bin/debug.  Then you need to open the vishnu sln in visual studio and change "any cpu" at top of visual studio screen to be "x64"
5. You should finally be able to build and run the program
