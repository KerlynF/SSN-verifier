# SSN
***

### Project Description

This project is about an application that evaluates an input of numbers that are the equivalent of the SSN (Social Security Number) saying if it is a valid number, following the rules, or not.


### Installation guide

The .NET SDK must be installed along with the compiler. Works from version 5.0 onwards

##### Installing on Linux

In linux you must put the following code in the terminal:

wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb 

This to give the permissions in the OS

##### Installing the SDK

To install the SDK we must put the following code in the terminal:

sudo apt update
sudo apt install -y apt-transport-https
sudo apt-get install -y dotnet-sdk-6.0

then it will start the installation.

Once installed we must position ourselves in the terminal in the folder where the source code is and use the following command: **dotnet run**

Once executed, a message will appear explaining that you must enter the 9 numbers of the SSN

### Application operation

A 9-digit number must be entered, which cannot have any type of symbols, or letters within which it will be determined if the combination completes a valid SSN.




