	s4packman.dll
	A .NET class library to read and modify .package files for The Sims 4 by Electronic Arts.
    Copyright (C) 2015  Timothy Browning

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

I started this project because I had not seen a conflict detector for the Sims 4 Mods directory like Delphy's program for Sims 3. So I set out to make one.

In the course of the research into what would be involved I realized I would need to parse the package files themselves. While this was possible through the s4pi libraries (and they are an awesome piece of work) I thought it could be a little simpler and more intuitive to set them up in a project for .NET. So I looked into what it would take for me to write a completely .NET class library assembly to do the job. I quickly realize it would be not only possible, but also extremely fun. I have been loving the experience of seeing the internals of the file format and writing the code to use it. As I have done so my ideas have moved beyond the scope of just writing a conflict detector and moved more towards a one-stop shop for Sims 4 Mods. My hope is that using this library will be easy and inuitive for the user as well as powerful in the control it gives.

While that is my end goal, the current issue is getting the libraries completed. After the .package file library (s4packman.dll) is done it will have a plugin system built into it that will take plugin libraries that can parse out the formats of the files contained in the .package files.

The current state of s4packman is pre-alpha. Currently it reads the header of the .package file but no index or info on the files contained in it. The testapp project included is just that. It uses the library and displays the raw information pulled from the .package file you choose. About the only practical use for it at this time is to verify that the file is a valid Sims 4 package.

I intend this project to be free (as in beer and as in freedom) and as such it is released under the GNU General Public License v3.0. A works using any part of this project MUST be offered under the same license without cost and source code for any said projects MUST be made freely available. If you see any project that uses these libraries but doesn't conform to the license please bring it to my attention.

The official home for the libraries is at:

https://github.com/moomanfl/s4packman

Tim Browning
aka MoomanFL
moomanfl@gmail.com

2536 Anastasia Dr.
South Daytona, FL USA
32119

5/17/2015