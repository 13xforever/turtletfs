Formerly known as tsvn-tfs-provider, this is a simple provider for TSVN or TGIT that allows you to select work items from TFS to be included in commit log.

Installation
============

1. Download and install latest [.NET Framework](https://www.microsoft.com/Net/Download.aspx) available;
  * 3.5 SP1 is mandatory, 4.0 or newer is recommended. 
2. [Team Explorer 2010](https://www.microsoft.com/en-us/download/details.aspx?id=329) (included with every edition of VS2010 except for Expresses);
3. Download and install latest Tortoise front-end available (optional):
  * [TortoiseSVN](http://tortoisesvn.net/downloads): 1.5 is mandatory, 1.6+ is recommended;
  * [TortoiseGit](https://tortoisegit.org): 1.2.1 is mandatory, 1.4.4+ is recommended. 
4. Download package and extract files ([WinRAR](http://rarlab.com/download.htm), [7-Zip](http://7-zip.org/download.html));
5. Follow instructions inside. 

Quick and Dirty™ build instructions
===================================

You'll need [Visual Studio 2010](https://www.visualstudio.com/) to build this project.

After the build is complete, there's Register.reg file in bin sub-folder that needs to be imported (only once) before plug-in could be used with any Tortoise front-end that supports IBugTraqProvider (TortoiseSVN/TortoiseGit). 
