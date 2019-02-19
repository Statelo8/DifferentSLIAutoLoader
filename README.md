# DifferentSLIAutoLoader
Simple console application made in C# for loading Nvidia unsigned driver.

## What is this for?

DifferentSLIAutoLoader is made for use with DifferentSLIAuto patch. It's a simple console application made in C# that allow you to load unsigned GPU driver without using Test Mode. 

## How to use it with DifferentSLIAuto patch?
1. Install original Nvidia Driver.
2. Download DifferentSLIAutoLoader from Github and extract it.
3. Copy nvlddmkm.sys from System32 to DifferentSLIAuto patch folder. You can search for "nvlddmkm" in System32 folder or open Device Manager and open GPU details, Driver tab, Driver details button and look for file there.
4. Patch nvlddmkm.sys with DifferentSLIAuto.exe or HexEditor (depending on version of driver).
5. Boot into safe mode.
6. Change the driver in System32 to the modified one.
7. Reboot computer.
8. Go to DifferetnSLIAutoLoader folder and run DifferentSLIAutoTools.exe.
9. Click "Load driver" button.
10. Go to Nvidia Control Panel and turn on SLI.
11. Go back to DifferentSLIAutoTools and click "Re-enable DSE" button.
12. Find Install script in DifferentSLIAutoLoader folder and run it as Admin.
13. Success!

##### If you move DifferetnSLIAutoLoader somewhere else on your PC, you need to run install script again to update location.

To find what you need to edit in HexEditor, head over to techpowerup forum:

https://www.techpowerup.com/forums/threads/sli-with-different-cards.158907/page-121#post-3987274

https://www.techpowerup.com/forums/threads/sli-with-different-cards.158907/page-121#post-3988487

## Respositories and apps used in DifferentSLIAutoLoader
DSEFix by hfiref0x:
https://github.com/hfiref0x/DSEFix

Shark by blindtiger:
https://github.com/9176324/Shark

DevManView by NirSoft:
https://www.nirsoft.net/utils/device_manager_view.html
