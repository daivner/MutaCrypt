# MutaCrypt

* This proyect started time ago, but i just upload a copy on git.
* MutaCrypt is one idea of mine, I dont know if this algoritm is already implemented by someone else, I just had the idea time ago and tried to develop in the best way.

MutaCrypt is a software that allows to modify a byte array (original data) ussing another byte array (key) resulting in a very different byte array (modified data), you can use the reverse process with the same key to get the original data.

Im strill working on different ways to improve the process but the actual version can be ussed.

## Prepare to run

You can donwload the project and use Visual Studio to compile it, this program is writen in C#, is a Windows Forms app, the framework is set in 2.0 (its not soo old software, but you can run it in a very old windows OS), if you need it you can use another net version to compile, if you have problems with this, let me know to verify this.

Right Now the project includes a class with the main logic of the algoritm, and one form for the graphic part. 

## Use

* 1.- Set the "Data In" with the big button on the top "Select File"
* 2.- Set the "Key Data" :
* * You can use the textbox "key" and write a simple string for the key or 
* * You can use the "Select File" button on the right to use a file for a key
* 3.- Set options:
* * Sum Factor: Each time all the bytes from the key are used, all the bytes are going to be modified with the KeySum*1 using the key variant for next bytes again
* * Switch Key: Each time all the bytes from the key are used, all the bytes are going to be modified, first byte now is the last, second byte now is the first, third now is the second...
* 4.- Options for resulting file name
* 5.- Options for resulting file name extension
* 6.- Original Left/Right, you can use one or other, but, for reverse (get the original data) you have to use the oposite


## Notes

In this version, you have to provide a file and you will have a file, and this update the file a byte level, in some cases you could have a file with (by accident) a virus-byte-sequency so, be aware from this with your antivirus.

## To-Do

* Improve and add more functions to modify the original key during the proccess
* Generate Usefull funtions for the software, like Bytes to String "0xFF" format to avoid the "fake virus" issue
* Get a Repo for MutaCrypt lib, and another for the GUI

## Thanks to

*  @Villanuevand Villanuevand - https://gist.github.com/Villanuevand/6386899f70346d4580c723232524d35a
For this example for readme file

