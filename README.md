# AppiumChromeTest
Basic Navgiate to URL test to ensure that appiumWebdriver is able to hit Appium Server remotely
and perform tests on Android emulator 

##Start up Appium Server on Remote Machine

1. Spin up Android emulator
2. Start up adb server. Navgiate to:
	`C:\\Users\\{user}\\AppData\\Local\\Android\\Sdk\\platform-tools`
3. Run follwoing command to list avaliable devices:
	`adb devices`
4. Start adb server:
	`adb start-server`
5. Spin up Appium Server
6. Configure host to:
	`172.16.0.7:4723`
7. Start server 
8. When testing is complete
	- stop Appium Server 
	- Stop adb server
		` adb kill-server`
