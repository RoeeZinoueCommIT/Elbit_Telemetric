=================================================
=						=
=						=
=		RTC LOGGER UTILITY - README 	=
=						=
=						=
=================================================


Overview
=========
This Readme file describes the usage of the RtcLogger.exe utility.
The utility should be used on any PC connected to the LAN where
the RTC targets are connected.
The utility will join the MULTICAST group according to specification 
and print to file each LOG entry received according to its configured listening port/IP.
USE THIS UTILITY ONLY FOR MULTICAST LOGGING!!!
In any other case of logging (UDP/TCP) - you should use other public terminals.

Configuration file
==================
The utility is configured using its INI file (RtcLogger.ini).
The configuration file should be built in the following way:

		[BASIC_DEFINES]
		2 !num of records
		<target directory to keep logs> !TARGET_DIR for log files
		<max size of log file in MB> !MAX_FILE_LENGTH of log files in MB
		[IP]
		xxx.xxx.xxx.xxx
		yyy.yyy.yyy.yyy
		[PORT]
		zzzz
		aaaa
	
	BASIC_DEFINES
	==========
	The BASIC_DEFINES section should contain the target directory used to save the log files and 
	the maximum size of a log files in MB.
	When this size is reached, the log file is "restarted", i.e: the log file is deleted and recreated.
	In such a case - all data received prior to the recreation is lost.
	The definitions must be written in that order exactly!

	IP section
	==========
	The IP section should contain MULTICAST IP addresses on which the logger should be listening.
	The multicast address is configure in the SERVER's offline configuration where the required RTC
	is integrated.

	PORT section
	==========
	The PORT section should contain required ports on which the logger should be listening.
	The port should be of the following format: 
		PORT NUMBER = 5000 + LS part of the target IP address (dot notation)

		EXAMPLE: target having IP 10.200.1.239 ---> PORT NUMBER = 5000 + 239 = 5239
	
Usage
=======
Place the RtcLogger.exe file in a directory of your choice.
Place the RtcLogger.ini file in a directory of your choice.
run the following command from the start->run menu:
	RtcLogger.exe <full path to the INI file> 

		The full path is of the sort: C:\RtcLogger\RtcLogger.ini

To stop the utility from running - simple enter "Q" or "q"

Operation
==========
The utility will open listening sockets for each IP/PORT it was configured with.
Each IP/PORT will be logged into a specific file named: 
	RTCLog_<IP>_<PORT>.txt

	The files will be placed at the TARGET_DIR
	(therefore - number of files opened = number of IP configured * number of ports configured)
